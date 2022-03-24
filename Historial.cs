using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taller.Models.DB.DAO;
using TallerXP;

namespace Taller
{
    public partial class Historial : Form
    {
        private int dni;
        private readonly TallerEntity _context;
        private string apellido;

        int idSeleccionado = -1;
        private string patenteSeleccionada;
        List<LineaArreglo> lineas;
        List<Arreglo> arreglos;
        float total;
        CultureInfo cultureinfo = new CultureInfo("es-AR");

        public Historial(int dni, TallerEntity context, string apellido)
        {
            this.dni = dni;
            this._context = context;
            this.apellido = apellido;
            InitializeComponent();
            label1.Text = "Historial Cliente " + apellido;
            cargarHistorialCliente();
            cargarAutosCliente();
            reset();
        }

        public Historial()
        {
        }

        private void reset()
        {

            listaDetalleArreglo.Visible = false;
            labelDescripcion.Visible = false;
            labelCantidad.Visible = false;
            labelPrecio.Visible = false;
            labelSubtotal.Visible = false;
            iconoAgregar.Visible = false;
            labelErrorCantidad.Visible = false;
            labelErrorDescripcion.Visible = false;
            labelErrorPrecio.Visible = false;
            textboxDescripcion.Visible = false;
            textboxCantidad.Visible = false;
            textboxPrecio.Visible = false;
            textboxSubtotal.Visible = false;
            labelErrorAgregar.Visible = false;
            labelTrabajo.Visible = false;
            botonAgregarTrabajo.Visible = false;
            botonBorrar.Visible = false;
            botonCancelarTrabajo.Visible = false;
            labelPrecioTotal.Visible = false;
            labelT.Visible = false;
            botonBorrarAuto.Enabled = false;
            labelErrorAgregarTrabajo.Visible = false;
            botonExcel.Visible = false;

            lineas = new List<LineaArreglo>();
            listaDetalleArreglo.Items.Clear();
            total = 0;
            labelPrecioTotal.Text = total.ToString("C2", cultureinfo);
        }
        private void botonNuevoTrabajo_Click(object sender, EventArgs e)
        {
            botonCancelarTrabajo.Visible = true;
            botonBorrar.Visible = true;
            botonAgregarTrabajo.Visible = true;
            labelPrecioTotal.Visible = true;
            labelT.Visible = true;
            labelTrabajo.Visible = false;
            textboxDescripcion.Visible = true;
            textboxCantidad.Visible = true;
            textboxPrecio.Visible = true;
            textboxSubtotal.Visible = true;
            listaDetalleArreglo.Visible = true;
            labelDescripcion.Visible = true;
            labelCantidad.Visible = true;
            labelPrecio.Visible = true;
            labelSubtotal.Visible = true;
            iconoAgregar.Visible = true;
            botonExcel.Visible = false;
            total = 0;
            listaDetalleArreglo.Items.Clear();
            labelPrecioTotal.Text = total.ToString("C2", cultureinfo);
        }

        private void botonAgregarTrabajo_Click(object sender, EventArgs e)
        {
            if (lineas.Count == 0)
            {
                labelErrorAgregarTrabajo.Text = "No hay trabajos";
                labelErrorAgregarTrabajo.Visible = true;
            }
            else
            {
                try
                {
                    labelErrorAgregarTrabajo.Visible = false;
                    Arreglo nuevoArreglo = new Arreglo();
                    nuevoArreglo.ClienteDNI = dni;
                    nuevoArreglo.Fecha = DateTime.Today;
                    nuevoArreglo.Total = total;

                    Arreglo agregado = ArregloDAO.AgregarArreglo(nuevoArreglo, _context);

                    foreach (LineaArreglo linea in lineas)
                    {
                        linea.idArreglo = agregado.id;
                        LineaArregloDAO.AgregarLineaArreglo(linea, _context);
                    }

                    arreglos.Add(agregado);

                    listaArreglos.Items.Clear();
                    foreach (Arreglo arreglo in arreglos)
                    {
                        ListViewItem itemArreglo = new ListViewItem(arreglo.id.ToString());
                        itemArreglo.SubItems.Add(DateTime.Parse(arreglo.Fecha.ToString()).ToString("dd/MM/yyyy"));
                        itemArreglo.SubItems.Add(float.Parse(arreglo.Total.ToString()).ToString("C2", cultureinfo));
                        listaArreglos.Items.Add(itemArreglo);
                    }

                    reset();
                    labelTrabajo.ForeColor = Color.Green;
                    labelTrabajo.Text = "Agregado";
                    labelTrabajo.Visible = true;
                }
                catch (Exception exc)
                {
                    labelErrorAgregarTrabajo.Text = exc.Message;
                    labelErrorAgregarTrabajo.Visible = true;
                }
            }

        }

        private void botonCancelarTrabajo_Click(object sender, EventArgs e)
        {
            //lineas.Clear();
            //listaDetalleArreglo.Clear();
            reset();
        }

        private void IconoAgregar_Click(object sender, EventArgs e)
        {
            if (labelErrorPrecio.Visible == false && labelErrorCantidad.Visible == false && labelErrorDescripcion.Visible == false)
            {
                if (textboxDescripcion.Text.Trim() != string.Empty && textboxCantidad.Text.Trim() != string.Empty && textboxPrecio.Text.Trim() != string.Empty)
                {
                    LineaArreglo nuevaLinea = new LineaArreglo();
                    nuevaLinea.Descripcion = textboxDescripcion.Text;
                    nuevaLinea.Subtotal = float.Parse(textboxSubtotal.Text.ToString().Replace('$', ' ').Trim());
                    nuevaLinea.Precio = float.Parse(textboxPrecio.Text);
                    nuevaLinea.Cantidad = Int32.Parse(textboxCantidad.Text);
                    lineas.Add(nuevaLinea);

                    labelErrorAgregarTrabajo.Visible = false;
                    labelErrorAgregar.Text = "Agregado";
                    labelErrorAgregar.ForeColor = Color.FromArgb(76, 231, 1);
                    labelErrorAgregar.Visible = true;
                    textboxCantidad.Text = "";
                    textboxPrecio.Text = "";
                    textboxSubtotal.Text = "";
                    textboxDescripcion.Text = "";

                    listaDetalleArreglo.Items.Clear();
                    total = 0;
                    foreach (LineaArreglo linea in lineas)
                    {
                        ListViewItem itemLinea = new ListViewItem(linea.Descripcion.ToString());
                        itemLinea.SubItems.Add(linea.Cantidad.ToString());
                        itemLinea.SubItems.Add(float.Parse(linea.Precio.ToString()).ToString("C2", cultureinfo));
                        itemLinea.SubItems.Add(float.Parse(linea.Subtotal.ToString()).ToString("C2", cultureinfo));
                        listaDetalleArreglo.Items.Add(itemLinea);
                        total += float.Parse(linea.Subtotal.ToString());
                    }
                    labelPrecioTotal.Text = total.ToString("C2", cultureinfo);
                }
                else
                {
                    labelErrorAgregar.Text = "Faltan datos";
                    labelErrorAgregar.Visible = true;
                }
            }
            else
            {
                labelErrorAgregar.Text = "Datos erroneos";
                labelErrorAgregar.Visible = true;
            }

        }
        private void Historial_Load(object sender, EventArgs e)
        {

        }

        private void descripcionText_Changed(object sender, EventArgs e)
        {
            //labelErrorAgregar.Visible = false;
            //labelErrorAgregar.ForeColor = Color.Red;
            //labelErrorDescripcion.Visible = false;
            //if (textboxDescripcion.Text.Trim() == string.Empty && agregado == false)
            //{
            //    labelErrorDescripcion.Text = "Agregar una descripcion";
            //    labelErrorDescripcion.Visible = true;
            //}
            //agregado = false;
        }

        private void cantidadText_Changed(object sender, EventArgs e)
        {
            int i = 0;
            float subtotal = 0;
            labelErrorAgregar.Visible = false;
            labelErrorAgregar.ForeColor = Color.Red;

            labelErrorCantidad.Visible = false;
            if (textboxCantidad.Text.Trim() != string.Empty && int.TryParse(textboxCantidad.Text, out i) != true)
            {
                labelErrorCantidad.Text = "Cantidad invalida";
                labelErrorCantidad.Visible = true;
            }
            else if (textboxCantidad.Text.Trim() != string.Empty && Int32.Parse(textboxCantidad.Text) <= 0)
            {
                labelErrorCantidad.Text = "Debe ser mayor a 0";
                labelErrorCantidad.Visible = true;
            }
            if (labelErrorCantidad.Visible == false && labelErrorPrecio.Visible == false && textboxCantidad.Text != string.Empty && textboxPrecio.Text != string.Empty)
            {
                subtotal = Int32.Parse(textboxCantidad.Text) * float.Parse(textboxPrecio.Text);
            }
            textboxSubtotal.Text = subtotal.ToString("C2", cultureinfo);
        }

        private void precioText_Changed(object sender, EventArgs e)
        {
            float i = 0;
            float subtotal = 0;
            labelErrorAgregar.Visible = false;
            labelErrorAgregar.ForeColor = Color.Red;
            labelErrorPrecio.Visible = false;
            bool flag = textboxPrecio.Text.Trim().Contains(".");
            if ((textboxPrecio.Text.Trim() != string.Empty && float.TryParse(textboxPrecio.Text, out i) != true) || (flag == true))
            {
                labelErrorPrecio.Text = "Precio invalido";
                labelErrorPrecio.Visible = true;
            }
            else if (textboxPrecio.Text.Trim() != string.Empty && float.Parse(textboxPrecio.Text) <= 0)
            {
                labelErrorPrecio.Text = "Debe ser mayor a 0";
                labelErrorPrecio.Visible = true;
            }
            if (labelErrorCantidad.Visible == false && labelErrorPrecio.Visible == false && textboxCantidad.Text != string.Empty && textboxPrecio.Text != string.Empty)
            {
                subtotal = Int32.Parse(textboxCantidad.Text) * float.Parse(textboxPrecio.Text);
            }
            textboxSubtotal.Text = subtotal.ToString("C2", cultureinfo);
        }

        private void botonBorrar_Click(object sender, EventArgs e)
        {
            int i = lineas.Count;
            if (i > 0)
                lineas.RemoveAt(lineas.Count - 1);
            recargarListaArreglos();

        }

        private void recargarListaArreglos()
        {
            listaDetalleArreglo.Items.Clear();
            total = 0;
            foreach (LineaArreglo linea in lineas)
            {
                ListViewItem itemLinea = new ListViewItem(linea.Descripcion.ToString());
                itemLinea.SubItems.Add(linea.Cantidad.ToString());
                itemLinea.SubItems.Add(float.Parse(linea.Precio.ToString()).ToString("C2", cultureinfo));
                itemLinea.SubItems.Add(float.Parse(linea.Subtotal.ToString()).ToString("C2", cultureinfo));
                listaDetalleArreglo.Items.Add(itemLinea);
                total += float.Parse(linea.Subtotal.ToString());
            }
            labelPrecioTotal.Text = total.ToString("C2", cultureinfo);
        }
        private void cargarHistorialCliente()
        {
            List<Arreglo> arreglosDAO = ArregloDAO.BuscarArreglosCliente(dni, _context);
            arreglos = arreglosDAO.ToList();
            foreach (Arreglo arreglo in arreglos)
            {
                ListViewItem itemArreglo = new ListViewItem(arreglo.id.ToString());
                itemArreglo.SubItems.Add(DateTime.Parse(arreglo.Fecha.ToString()).ToString("dd/MM/yyyy"));
                itemArreglo.SubItems.Add(float.Parse(arreglo.Total.ToString()).ToString("C2", cultureinfo));
                listaArreglos.Items.Add(itemArreglo);
            }
        }



        private void indexListaArreglos_Changed(object sender, EventArgs e)
        {
            reset();
            ListViewItem seleccionado;
            try
            {
                seleccionado = listaArreglos.SelectedItems[0];
            }
            catch (Exception exc)
            {
                seleccionado = null;
                botonExcel.Visible = false;
            }
            if (seleccionado != null)
            {
                idSeleccionado = Int32.Parse(seleccionado.Text);
                listaDetalleArreglo.Visible = true;
                cargarTrabajo(idSeleccionado);
                botonExcel.Visible = true;
            }
        }
        private void cargarTrabajo(int idTrabajo)
        {
            List<LineaArreglo> lineasDAO = LineaArregloDAO.BuscarLineasPorId(idTrabajo, _context);
            listaDetalleArreglo.Items.Clear();
            foreach (LineaArreglo linea in lineasDAO)
            {
                ListViewItem itemLinea = new ListViewItem(linea.Descripcion.ToString());
                itemLinea.SubItems.Add(linea.Cantidad.ToString());
                itemLinea.SubItems.Add(float.Parse(linea.Precio.ToString()).ToString("C2", cultureinfo));
                itemLinea.SubItems.Add(float.Parse(linea.Subtotal.ToString()).ToString("C2", cultureinfo));
                listaDetalleArreglo.Items.Add(itemLinea);
                total += float.Parse(linea.Subtotal.ToString());
            }
        }
        private void cargarAutosCliente()
        {
            listaAutos.Items.Clear();
            List<Auto> autosDAO = AutoDAO.BuscarAutosCliente(dni, _context);
            List<Auto> autos = autosDAO.ToList();
            foreach (Auto auto in autos)
            {
                ListViewItem itemAuto = new ListViewItem(auto.Patente.ToString());
                itemAuto.SubItems.Add(auto.Marca.ToString());
                itemAuto.SubItems.Add(auto.Modelo.ToString());
                itemAuto.SubItems.Add(auto.anio.ToString());
                listaAutos.Items.Add(itemAuto);
            }
        }

        private void botonBorrarAuto_Click(object sender, EventArgs e)
        {
            AutoDAO.BorrarAutoPatente(patenteSeleccionada, _context);
            listaAutos.Items.Clear();
            List<Auto> autosDAO = AutoDAO.BuscarAutosCliente(dni, _context);
            List<Auto> autos = autosDAO.ToList();
            foreach (Auto auto in autos)
            {
                ListViewItem itemAuto = new ListViewItem(auto.Patente.ToString());
                itemAuto.SubItems.Add(auto.Marca.ToString());
                itemAuto.SubItems.Add(auto.Modelo.ToString());
                itemAuto.SubItems.Add(auto.anio.ToString());
                listaAutos.Items.Add(itemAuto);
            }
        }

        private void indexListaAutos_Changed(object sender, EventArgs e)
        {
            ListViewItem autoSeleccionado;
            try
            {
                autoSeleccionado = listaAutos.SelectedItems[0];
            }
            catch (Exception exc)
            {
                autoSeleccionado = null;
            }
            if (autoSeleccionado != null)
            {
                patenteSeleccionada = autoSeleccionado.Text;
                botonBorrarAuto.Enabled = true;
            }
        }

        private void botonExcel_Click(object sender, EventArgs e)
        {
            Arreglo arreglo = ArregloDAO.BuscarArregloID(idSeleccionado, _context);
            Cliente cliente = ClienteDAO.BuscarCliente(dni, _context);
            string ruta = SaveScreen(arreglo);
            if (ruta != null && cliente != null && arreglo != null)
            {
                try
                {
                    string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
                    var workbook = new XLWorkbook(folder + "\\Template.xlsx");
                    var ws = workbook.Worksheets.Worksheet("Template");
                    string LetraCelda = "A";
                    int NumCelda = 17;
                    int i = 0;
                    ws.Cell("F25").Value = arreglo.Total;
                    List<LineaArreglo> lineas = LineaArregloDAO.BuscarLineasPorId(idSeleccionado, _context);
                    foreach (LineaArreglo linea in lineas)
                    {
                        ws.Cell(LetraCelda + NumCelda.ToString()).Value = linea.Descripcion;
                        ws.Cell(LetraCelda + NumCelda.ToString()).Style.Font.FontSize = 11;
                        ws.Cell(LetraCelda + NumCelda.ToString()).Style.Font.FontColor = XLColor.Black;
                        LetraCelda = "D";
                        ws.Cell(LetraCelda + NumCelda.ToString()).Value = linea.Cantidad;
                        ws.Cell(LetraCelda + NumCelda.ToString()).Style.Font.FontSize = 11;
                        ws.Cell(LetraCelda + NumCelda.ToString()).Style.Font.FontColor = XLColor.Black;
                        LetraCelda = "E";
                        ws.Cell(LetraCelda + NumCelda.ToString()).Value = linea.Precio;
                        ws.Cell(LetraCelda + NumCelda.ToString()).Style.Font.FontSize = 11;
                        ws.Cell(LetraCelda + NumCelda.ToString()).Style.Font.FontColor = XLColor.Black;
                        ws.Cell(LetraCelda + NumCelda.ToString()).Style.NumberFormat.Format = "[$$-es-AR] #,##0.00000";
                        ws.Cell(LetraCelda + NumCelda.ToString()).DataType = XLDataType.Number;
                        LetraCelda = "F";
                        ws.Cell(LetraCelda + NumCelda.ToString()).Value = linea.Subtotal;
                        ws.Cell(LetraCelda + NumCelda.ToString()).Style.Font.FontSize = 11;
                        ws.Cell(LetraCelda + NumCelda.ToString()).Style.Font.FontColor = XLColor.Black;
                        ws.Cell(LetraCelda + NumCelda.ToString()).Style.NumberFormat.Format = "[$$-es-AR] #,##0.00000";
                        ws.Cell(LetraCelda + NumCelda.ToString()).DataType = XLDataType.Number;

                        LetraCelda = "A";
                        NumCelda++;
                        if (i > 2)
                            ws.Row(NumCelda).InsertRowsBelow(1);
                        i++;
                    }
                    ws.Cell("A9").Value = dni;
                    ws.Cell("A10").Value = cliente.Nombre + " " + cliente.Apellido;
                    ws.Cell("F4").Value = DateTime.Parse(arreglo.Fecha.ToString()).ToString("dd-MM-yyyy");
                    ws.Cell("F3").Value = arreglo.id;
                    
                    workbook.SaveAs(ruta);
                    MessageBox.Show("Exportado con exito");
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Error al exportar");
            }
        }
        private string SaveScreen(Arreglo arreglo)
        {
            String ruta= null;
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = ".xlsx";
                saveFile.FileName = "Trabajo " + arreglo.id + " - " + apellido + " - " + dni + "_" + DateTime.Parse(arreglo.Fecha.ToString()).ToString("dd-MM-yyyy");
                saveFile.Filter = "Libro de Excel (*.xlsx) | *.xlsx";
                if (saveFile.ShowDialog() == DialogResult.OK)
                    ruta = saveFile.FileName;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
                return ruta;
            }
            return ruta;
        }
        public void actualizarListaAutos()
        {
            listaAutos.Items.Clear();
            List<Auto> autosDAO = AutoDAO.BuscarAutosCliente(dni, _context);
            List<Auto> autos = autosDAO.ToList();
            foreach (Auto auto in autos)
            {
                ListViewItem itemAuto = new ListViewItem(auto.Patente.ToString());
                itemAuto.SubItems.Add(auto.Marca.ToString());
                itemAuto.SubItems.Add(auto.Modelo.ToString());
                itemAuto.SubItems.Add(auto.anio.ToString());
                listaAutos.Items.Add(itemAuto);
            }
        }
    }
}

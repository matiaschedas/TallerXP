using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Taller.Models.DB.DAO;
using Taller.Servicios;
using TallerXP;

namespace Taller
{
    public partial class Clientes : Form
    {
        private readonly TallerEntity _context = new TallerEntity();
        //private readonly TallerDBContext _context = new TallerDBContext();
        List<Cliente> clientes;
        List<Historial> ventanas;
        string dniSeleccionado;
        public Clientes()
        {
            InitializeComponent();
            ventanas = new List<Historial>();
            labelDNI.Visible = false;
            textboxDNI.Visible = false;

            labelNombre.Visible = false;
            textboxNombre.Visible = false;

            labelApellido.Visible = false;
            textboxApellido.Visible = false;

            botonAgregarCliente.Visible = false;

            labelErrorApellido.Visible = false;
            labelErrorNombre.Visible = false;
            labelErrorDNI.Visible = false;
            labelErrorAgregarCliente.Visible = false;
            labelExitoAgregarCliente.Visible = false;
            botonEditarCliente.Enabled = false;
            botonHistorialCliente.Enabled = false;
            botonAgregarAuto.Enabled = false;
            botonGuardarEditado.Visible = false;

            textboxMarca.Visible = false;
            textboxModelo.Visible = false;
            textboxAnio.Visible = false;
            textboxPatente.Visible = false;
            labelMarca.Visible = false;
            labelModelo.Visible = false;
            labelAnio.Visible = false;
            labelPatente.Visible = false;
            labelErrorAnio.Visible = false;
            labelErrorMarca.Visible = false;
            labelErrorModelo.Visible = false;
            labelErrorPatente.Visible = false;
            labelErrorAuto.Visible = false;
            botonAgregarAuto.Enabled = false;
            botonOKAuto.Visible = false;
            botonCancelarNuevoCliente.Visible = false;
            botonCancelarAuto.Visible = false;

            labelAutoAgregado.Visible = false;
            clientes = ClienteDAO.BuscarTodosClientes(_context);
            cargarClientes();
        }

        private void botonNuevoCliente_Click(object sender, EventArgs e)
        {
            botonEditarCliente.Enabled = false;
            botonHistorialCliente.Enabled = false;
            botonAgregarAuto.Enabled = false;
            labelDNI.Visible = true;
            textboxDNI.Visible = true;
            labelNombre.Visible = true;
            textboxNombre.Visible = true;
            labelApellido.Visible = true;
            textboxApellido.Visible = true;
            botonAgregarCliente.Visible = true;
            labelExitoAgregarCliente.Visible = false;
            botonGuardarEditado.Visible = false;
            textboxDNI.Enabled = true;
            botonCancelarNuevoCliente.Visible = true;
            textboxDNI.Text = "";
            textboxNombre.Text = "";
            textboxApellido.Text = "";
            labelErrorDNI.Visible = false;
            labelErrorNombre.Visible = false;
            labelErrorApellido.Visible = false;
            labelErrorAgregarCliente.Visible = false;
        }
        private void cargarTodosClientes()
        {
            clientes = ClienteDAO.BuscarTodosClientes(_context);
            listaClientes.Items.Clear();
            foreach (Cliente cliente in clientes)
            {
                ListViewItem itemCliente = new ListViewItem(cliente.DNI.ToString());
                itemCliente.SubItems.Add(cliente.Nombre);
                itemCliente.SubItems.Add(cliente.Apellido);
                itemCliente.SubItems.Add(DateTime.Parse(cliente.FechaCreacion.ToString()).ToString("dd/MM/yyyy"));
                listaClientes.Items.Add(itemCliente);

            }

        }
        private void cargarClientes()
        {
            listaClientes.Items.Clear();
            foreach (Cliente cliente in clientes)
            {
                ListViewItem itemCliente = new ListViewItem(cliente.DNI.ToString());
                itemCliente.SubItems.Add(cliente.Nombre);
                itemCliente.SubItems.Add(cliente.Apellido);
                itemCliente.SubItems.Add(DateTime.Parse(cliente.FechaCreacion.ToString()).ToString("dd/MM/yyyy"));
                listaClientes.Items.Add(itemCliente);

            }
        }




        private void botonAgregarCliente_Click(object sender, EventArgs e)
        {
            if (labelErrorDNI.Visible == false && labelErrorNombre.Visible == false && labelErrorApellido.Visible == false)
            {
                if (textboxApellido.Text.Trim() != string.Empty && textboxNombre.Text.Trim() != string.Empty && textboxDNI.Text.Trim() != string.Empty)
                {
                    try
                    {
                        ClienteService.AgregarCliente(Int32.Parse(textboxDNI.Text.Trim()), textboxNombre.Text.Trim(), textboxApellido.Text.Trim(), DateTime.Today, _context);


                        labelDNI.Visible = false;
                        textboxDNI.Visible = false;
                        textboxDNI.Text = "";
                        labelNombre.Visible = false;
                        textboxNombre.Visible = false;
                        textboxNombre.Text = "";
                        labelApellido.Visible = false;
                        textboxApellido.Visible = false;
                        textboxApellido.Text = "";
                        botonAgregarCliente.Visible = false;
                        labelExitoAgregarCliente.Text = "Cliente agregado con exito";
                        botonCancelarNuevoCliente.Visible = false;
                        labelExitoAgregarCliente.ForeColor = Color.Green;
                        labelExitoAgregarCliente.Visible = true;

                        botonEditarCliente.Enabled = false;
                        botonHistorialCliente.Enabled = false;
                        botonAgregarAuto.Enabled = false;
                        labelErrorAgregarCliente.Visible = false;

                        List<Cliente> clientes = ClienteDAO.BuscarTodosClientes(_context);
                        listaClientes.Items.Clear();
                        foreach (Cliente cliente in clientes)
                        {
                            ListViewItem itemCliente = new ListViewItem(cliente.DNI.ToString());
                            itemCliente.SubItems.Add(cliente.Nombre);
                            itemCliente.SubItems.Add(cliente.Apellido);
                            itemCliente.SubItems.Add(DateTime.Parse(cliente.FechaCreacion.ToString()).ToString("dd/MM/yyyy"));
                            listaClientes.Items.Add(itemCliente);

                        }
                    }
                    catch(Exception exc)
                    {
                        labelExitoAgregarCliente.Text = exc.Message;
                        labelExitoAgregarCliente.ForeColor = Color.Red;
                        labelExitoAgregarCliente.Visible = true;
                    }
                }
                else
                {
                    labelErrorAgregarCliente.Text = "Error, complete todos los campos";
                    labelErrorAgregarCliente.Visible = true;
                }
            }
            else
            {
                labelErrorAgregarCliente.Text = "Error, tiene algun dato erroneo";
                labelErrorAgregarCliente.Visible = true;
            }
        }

        private void textDNI_Changed(object sender, EventArgs e)
        {
            int i = 0;
            labelErrorDNI.Visible = false;
            if (textboxDNI.Text.Trim() != string.Empty && int.TryParse(textboxDNI.Text, out i) != true)
            {
                labelErrorDNI.Text = "Dni incorrecto";
                labelErrorDNI.Visible = true;
            }
        }

        private void textNombre_Changed(object sender, EventArgs e)
        {

            labelErrorNombre.Visible = false;
            if (textboxNombre.Text.Trim() != string.Empty && !textboxNombre.Text.Replace(" ", "").All(Char.IsLetter))
            {
                labelErrorNombre.Text = "Nombre incorrecto";
                labelErrorNombre.Visible = true;
            }
        }

        private void textApellido_Changed(object sender, EventArgs e)
        {

            labelErrorApellido.Visible = false;
            if (textboxApellido.Text.Trim() != string.Empty && !textboxApellido.Text.Replace(" ", "").All(Char.IsLetter))
            {
                labelErrorApellido.Text = "Apellido incorrecto";
                labelErrorApellido.Visible = true;
            }
        }

        private void textBuscarCliente_Changed(object sender, EventArgs e)
        {
            botonHistorialCliente.Enabled = false;
            botonEditarCliente.Enabled = false;
            botonAgregarAuto.Enabled = false;
            cargarTodosClientes();
            List<Cliente> copiaClientes = new List<Cliente>();
            copiaClientes = clientes.ToList();

            foreach (Cliente cliente in copiaClientes)
            {
                if (cliente.Apellido.ToLower().IndexOf(textboxBuscarCliente.Text.ToLower()) == -1 && cliente.Nombre.ToLower().IndexOf(textboxBuscarCliente.Text.ToLower()) == -1 && cliente.DNI.ToString().ToLower().IndexOf(textboxBuscarCliente.Text.ToLower()) == -1)
                {
                    clientes.Remove(cliente);
                }
            }
            cargarClientes();

        }


        private void botonEditarCliente_Click(object sender, EventArgs e)
        {
            Cliente clienteBuscado = ClienteDAO.BuscarCliente(Int32.Parse(dniSeleccionado), _context);
            textboxNombre.Text = clienteBuscado.Nombre;
            textboxApellido.Text = clienteBuscado.Apellido;
            textboxDNI.Text = clienteBuscado.DNI.ToString();

            botonCancelarNuevoCliente.Visible = true;
            labelDNI.Visible = true;
            textboxDNI.Visible = true;
            textboxDNI.Enabled = false;
            labelNombre.Visible = true;
            textboxNombre.Visible = true;
            labelApellido.Visible = true;
            textboxApellido.Visible = true;
            botonGuardarEditado.Visible = true;
            labelExitoAgregarCliente.Visible = false;
            botonAgregarCliente.Visible = false;
        }

        private void verHistorial_Click(object sender, EventArgs e)
        {
            Cliente cliente = ClienteDAO.BuscarCliente(Int32.Parse(dniSeleccionado), _context);
            Historial ventanaHistorial = new Historial(Int32.Parse(dniSeleccionado), _context, cliente.Apellido);
            ventanas.Add(ventanaHistorial);
            ventanaHistorial.Show();
        }

        private void indexLista_Changed(object sender, EventArgs e)
        {
            botonEditarCliente.Enabled = true;
            botonHistorialCliente.Enabled = true;
            botonAgregarAuto.Enabled = true;
            ListViewItem seleccionado;
            try
            {
                seleccionado = listaClientes.SelectedItems[0];
            }
            catch (Exception exc)
            {
                seleccionado = null;
                botonEditarCliente.Enabled = false;
                botonHistorialCliente.Enabled = false;
                botonAgregarAuto.Enabled = false;
            }
            if (seleccionado != null)
                dniSeleccionado = seleccionado.Text.Trim();

            else
                dniSeleccionado = null;



        }

        private void botonGuardarEditado_Click(object sender, EventArgs e)
        {
            Cliente buscado = ClienteDAO.BuscarCliente(Int32.Parse(dniSeleccionado), _context);
            try
            {
                if (labelErrorDNI.Visible == false && labelErrorNombre.Visible == false && labelErrorApellido.Visible == false)
                {
                    if (textboxApellido.Text.Trim() != string.Empty && textboxNombre.Text.Trim() != string.Empty && textboxDNI.Text.Trim() != string.Empty)
                    {
                        Cliente editado = new Cliente();
                        editado.Apellido = textboxApellido.Text.Trim();
                        editado.Nombre = textboxNombre.Text.Trim();
                        editado.DNI = buscado.DNI;
                        ClienteDAO.EditarCliente(editado, _context);
                        labelDNI.Visible = false;
                        textboxDNI.Visible = false;
                        textboxDNI.Text = "";
                        labelNombre.Visible = false;
                        textboxNombre.Visible = false;
                        textboxNombre.Text = "";
                        labelApellido.Visible = false;
                        textboxApellido.Visible = false;
                        textboxApellido.Text = "";
                        botonAgregarCliente.Visible = false;
                        botonGuardarEditado.Visible = false;

                        botonEditarCliente.Enabled = false;
                        botonHistorialCliente.Enabled = false;
                        botonAgregarAuto.Enabled = false;

                        labelExitoAgregarCliente.Text = "Cliente editado con exito";
                        labelExitoAgregarCliente.ForeColor = Color.Green;
                        labelExitoAgregarCliente.Visible = true;
                        botonCancelarNuevoCliente.Visible = false;
                        labelErrorAgregarCliente.Visible = false;

                        List<Cliente> clientes = ClienteDAO.BuscarTodosClientes(_context);
                        listaClientes.Items.Clear();
                        foreach (Cliente cliente in clientes)
                        {
                            ListViewItem itemCliente = new ListViewItem(cliente.DNI.ToString());
                            itemCliente.SubItems.Add(cliente.Nombre);
                            itemCliente.SubItems.Add(cliente.Apellido);
                            itemCliente.SubItems.Add(DateTime.Parse(cliente.FechaCreacion.ToString()).ToString("dd/MM/yyyy"));
                            listaClientes.Items.Add(itemCliente);

                        }
                    }
                    else
                    {
                        labelErrorAgregarCliente.Text = "Error, complete todos los campos";
                        labelErrorAgregarCliente.Visible = true;
                    }
                }
                else
                {
                    labelErrorAgregarCliente.Text = "Error, tiene algun dato erroneo";
                    labelErrorAgregarCliente.Visible = true;
                }
            }
            catch(Exception exc)
            {
                labelErrorAgregarCliente.Text = exc.Message;
                labelErrorAgregarCliente.Visible = true;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void botonAgregarAuto_Click(object sender, EventArgs e)
        {
            botonCancelarAuto.Visible = true;
            textboxMarca.Visible = true;
            textboxModelo.Visible = true;
            textboxAnio.Visible = true;
            textboxPatente.Visible = true;
            labelErrorAnio.Visible = false;
            labelErrorPatente.Visible = false;
            labelErrorModelo.Visible = false;
            labelErrorMarca.Visible = false;

            textboxMarca.Text = "";
            textboxModelo.Text = "";
            textboxAnio.Text = "";
            textboxPatente.Text = "";

            labelMarca.Visible = true;
            labelModelo.Visible = true;
            labelAnio.Visible = true;
            labelPatente.Visible = true;
            labelAutoAgregado.Visible = false;
            botonOKAuto.Visible = true;
        }

        private void botonOKAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelErrorAnio.Visible == false && labelErrorModelo.Visible == false && labelErrorMarca.Visible == false && labelErrorPatente.Visible == false)
                {
                    if (textboxAnio.Text.Trim() != string.Empty && textboxModelo.Text.Trim() != string.Empty && textboxMarca.Text.Trim() != string.Empty && textboxPatente.Text.Trim() != string.Empty)
                    {
                        labelErrorAuto.Visible = false;
                        Auto nuevoAuto = new Auto();
                        AutoService.AgregarAuto(textboxPatente.Text.Trim(), textboxModelo.Text.Trim(), textboxMarca.Text.Trim(), Int32.Parse(textboxAnio.Text.Trim()), Int32.Parse(dniSeleccionado), _context);
                        textboxMarca.Visible = false;
                        textboxModelo.Visible = false;
                        textboxAnio.Visible = false;
                        textboxPatente.Visible = false;
                        labelMarca.Visible = false;
                        labelModelo.Visible = false;
                        labelAnio.Visible = false;
                        labelPatente.Visible = false;
                        labelAutoAgregado.ForeColor = Color.Green;
                        labelAutoAgregado.Text = "Auto Agregado";
                        labelAutoAgregado.Visible = true;
                        botonOKAuto.Visible = false;
                        botonCancelarAuto.Visible = false;
                        foreach(Historial ventana in ventanas)
                        {
                            ventana.actualizarListaAutos();
                        }
                    }
                    else
                    {
                        labelErrorAuto.Text = "Faltan datos";
                        labelErrorAuto.Visible = true;
                    }
                }
                else
                {
                    labelErrorAuto.Text = "Hay datos erroneos";
                    labelErrorAuto.Visible = true;
                }
            }
            catch (Exception exc)
            {
                labelErrorAuto.Text = exc.Message;
                labelErrorAuto.Visible = true;
            }
        }

        private void marcaText_Changed(object sender, EventArgs e)
        {
            labelErrorMarca.Visible = false;
            if (textboxMarca.Text.Trim() == string.Empty)
            {
                labelErrorMarca.Text = "Completar Marca";
                labelErrorMarca.Visible = true;
            }
        }

        private void anioText_Changed(object sender, EventArgs e)
        {
            int i = 0;
            labelErrorAnio.Visible = false;
            if (textboxAnio.Text.Trim() != string.Empty && int.TryParse(textboxAnio.Text, out i) != true)
            {
                labelErrorAnio.Text = "Año incorrecto";
                labelErrorAnio.Visible = true;
            }
        }

        private void modeloText_Changed(object sender, EventArgs e)
        {
            labelErrorModelo.Visible = false;
            if (textboxModelo.Text.Trim() == string.Empty)
            {
                labelErrorModelo.Text = "Completar Modelo";
                labelErrorModelo.Visible = true;
            }
        }

        private void patenteText_Changed(object sender, EventArgs e)
        {
            labelErrorPatente.Visible = false;
            if (textboxPatente.Text.Trim() == string.Empty)
            {
                labelErrorPatente.Text = "Completar Patente";
                labelErrorPatente.Visible = true;
            }
        }

        private void botonCancelarNuevoCliente_Click(object sender, EventArgs e)
        {
            labelDNI.Visible = false;
            textboxDNI.Visible = false;
            labelNombre.Visible = false;
            textboxNombre.Visible = false;
            labelApellido.Visible = false;
            textboxApellido.Visible = false;
            botonAgregarCliente.Visible = false;
            labelExitoAgregarCliente.Visible = false;
            botonGuardarEditado.Visible = false;
            textboxDNI.Enabled = false;
            botonCancelarNuevoCliente.Visible = false;
        }

        private void botonCancelarAuto_Click(object sender, EventArgs e)
        {
            

            textboxMarca.Visible = false;
            textboxModelo.Visible = false;
            textboxAnio.Visible = false;
            textboxPatente.Visible = false;
            labelErrorAnio.Visible = false;
            labelErrorPatente.Visible = false;
            labelErrorModelo.Visible = false;
            labelErrorMarca.Visible = false;
            labelErrorAuto.Visible = false;

            textboxMarca.Text = "";
            textboxModelo.Text = "";
            textboxAnio.Text = "";
            textboxPatente.Text = "";

            labelMarca.Visible = false;
            labelModelo.Visible = false;
            labelAnio.Visible = false;
            labelPatente.Visible = false;
            labelAutoAgregado.Visible = false;
            botonOKAuto.Visible = false;
            botonCancelarAuto.Visible = false;
        }
    }
}


namespace Taller
{
    partial class Historial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.label1 = new System.Windows.Forms.Label();
            this.listaArreglos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listaDetalleArreglo = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.botonNuevoTrabajo = new System.Windows.Forms.Button();
            this.textboxDescripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.botonAgregarTrabajo = new System.Windows.Forms.Button();
            this.botonCancelarTrabajo = new System.Windows.Forms.Button();
            this.textboxCantidad = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textboxPrecio = new System.Windows.Forms.TextBox();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.textboxSubtotal = new System.Windows.Forms.TextBox();
            this.labelErrorDescripcion = new System.Windows.Forms.Label();
            this.labelErrorCantidad = new System.Windows.Forms.Label();
            this.labelErrorPrecio = new System.Windows.Forms.Label();
            this.labelErrorAgregar = new System.Windows.Forms.Label();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.labelT = new System.Windows.Forms.Label();
            this.labelPrecioTotal = new System.Windows.Forms.Label();
            this.labelTrabajo = new System.Windows.Forms.Label();
            this.listaAutos = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.botonBorrarAuto = new System.Windows.Forms.Button();
            this.labelErrorAgregarTrabajo = new System.Windows.Forms.Label();
            this.iconoAgregar = new System.Windows.Forms.PictureBox();
            this.botonExcel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconoAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historial Cliente";
            // 
            // listaArreglos
            // 
            this.listaArreglos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listaArreglos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaArreglos.HideSelection = false;
            this.listaArreglos.Location = new System.Drawing.Point(13, 64);
            this.listaArreglos.Name = "listaArreglos";
            this.listaArreglos.Size = new System.Drawing.Size(328, 126);
            this.listaArreglos.TabIndex = 2;
            this.listaArreglos.UseCompatibleStateImageBehavior = false;
            this.listaArreglos.View = System.Windows.Forms.View.Details;
            this.listaArreglos.SelectedIndexChanged += new System.EventHandler(this.indexListaArreglos_Changed);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total";
            this.columnHeader3.Width = 100;
            // 
            // listaDetalleArreglo
            // 
            this.listaDetalleArreglo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listaDetalleArreglo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaDetalleArreglo.HideSelection = false;
            this.listaDetalleArreglo.Location = new System.Drawing.Point(10, 285);
            this.listaDetalleArreglo.Name = "listaDetalleArreglo";
            this.listaDetalleArreglo.Size = new System.Drawing.Size(669, 206);
            this.listaDetalleArreglo.TabIndex = 3;
            this.listaDetalleArreglo.UseCompatibleStateImageBehavior = false;
            this.listaDetalleArreglo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descripcion";
            this.columnHeader4.Width = 365;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cantidad";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Precio";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Subtotal";
            this.columnHeader7.Width = 120;
            // 
            // botonNuevoTrabajo
            // 
            this.botonNuevoTrabajo.ForeColor = System.Drawing.Color.Black;
            this.botonNuevoTrabajo.Location = new System.Drawing.Point(13, 198);
            this.botonNuevoTrabajo.Name = "botonNuevoTrabajo";
            this.botonNuevoTrabajo.Size = new System.Drawing.Size(154, 28);
            this.botonNuevoTrabajo.TabIndex = 4;
            this.botonNuevoTrabajo.Text = "Nuevo Trabajo";
            this.botonNuevoTrabajo.UseVisualStyleBackColor = true;
            this.botonNuevoTrabajo.Click += new System.EventHandler(this.botonNuevoTrabajo_Click);
            // 
            // textboxDescripcion
            // 
            this.textboxDescripcion.Location = new System.Drawing.Point(13, 245);
            this.textboxDescripcion.Name = "textboxDescripcion";
            this.textboxDescripcion.Size = new System.Drawing.Size(389, 20);
            this.textboxDescripcion.TabIndex = 5;
            this.textboxDescripcion.TextChanged += new System.EventHandler(this.descripcionText_Changed);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(13, 229);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 6;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(419, 229);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 7;
            this.labelCantidad.Text = "Cantidad";
            // 
            // botonAgregarTrabajo
            // 
            this.botonAgregarTrabajo.ForeColor = System.Drawing.Color.Black;
            this.botonAgregarTrabajo.Location = new System.Drawing.Point(540, 534);
            this.botonAgregarTrabajo.Name = "botonAgregarTrabajo";
            this.botonAgregarTrabajo.Size = new System.Drawing.Size(139, 34);
            this.botonAgregarTrabajo.TabIndex = 77;
            this.botonAgregarTrabajo.Text = "Agregar Trabajo";
            this.botonAgregarTrabajo.UseVisualStyleBackColor = true;
            this.botonAgregarTrabajo.Click += new System.EventHandler(this.botonAgregarTrabajo_Click);
            // 
            // botonCancelarTrabajo
            // 
            this.botonCancelarTrabajo.ForeColor = System.Drawing.Color.Black;
            this.botonCancelarTrabajo.Location = new System.Drawing.Point(10, 534);
            this.botonCancelarTrabajo.Name = "botonCancelarTrabajo";
            this.botonCancelarTrabajo.Size = new System.Drawing.Size(139, 34);
            this.botonCancelarTrabajo.TabIndex = 78;
            this.botonCancelarTrabajo.Text = "Cancelar";
            this.botonCancelarTrabajo.UseVisualStyleBackColor = true;
            this.botonCancelarTrabajo.Click += new System.EventHandler(this.botonCancelarTrabajo_Click);
            // 
            // textboxCantidad
            // 
            this.textboxCantidad.Location = new System.Drawing.Point(419, 245);
            this.textboxCantidad.Name = "textboxCantidad";
            this.textboxCantidad.Size = new System.Drawing.Size(50, 20);
            this.textboxCantidad.TabIndex = 8;
            this.textboxCantidad.TextChanged += new System.EventHandler(this.cantidadText_Changed);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(475, 229);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 10;
            this.labelPrecio.Text = "Precio";
            // 
            // textboxPrecio
            // 
            this.textboxPrecio.Location = new System.Drawing.Point(475, 245);
            this.textboxPrecio.Name = "textboxPrecio";
            this.textboxPrecio.Size = new System.Drawing.Size(61, 20);
            this.textboxPrecio.TabIndex = 9;
            this.textboxPrecio.TextChanged += new System.EventHandler(this.precioText_Changed);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(542, 229);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(46, 13);
            this.labelSubtotal.TabIndex = 12;
            this.labelSubtotal.Text = "Subtotal";
            // 
            // textboxSubtotal
            // 
            this.textboxSubtotal.Enabled = false;
            this.textboxSubtotal.Location = new System.Drawing.Point(542, 245);
            this.textboxSubtotal.Name = "textboxSubtotal";
            this.textboxSubtotal.Size = new System.Drawing.Size(77, 20);
            this.textboxSubtotal.TabIndex = 11;
            // 
            // labelErrorDescripcion
            // 
            this.labelErrorDescripcion.AutoSize = true;
            this.labelErrorDescripcion.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDescripcion.Location = new System.Drawing.Point(25, 267);
            this.labelErrorDescripcion.Name = "labelErrorDescripcion";
            this.labelErrorDescripcion.Size = new System.Drawing.Size(35, 13);
            this.labelErrorDescripcion.TabIndex = 80;
            this.labelErrorDescripcion.Text = "label6";
            // 
            // labelErrorCantidad
            // 
            this.labelErrorCantidad.AutoSize = true;
            this.labelErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCantidad.Location = new System.Drawing.Point(419, 267);
            this.labelErrorCantidad.Name = "labelErrorCantidad";
            this.labelErrorCantidad.Size = new System.Drawing.Size(35, 13);
            this.labelErrorCantidad.TabIndex = 81;
            this.labelErrorCantidad.Text = "label6";
            // 
            // labelErrorPrecio
            // 
            this.labelErrorPrecio.AutoSize = true;
            this.labelErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPrecio.Location = new System.Drawing.Point(478, 267);
            this.labelErrorPrecio.Name = "labelErrorPrecio";
            this.labelErrorPrecio.Size = new System.Drawing.Size(35, 13);
            this.labelErrorPrecio.TabIndex = 82;
            this.labelErrorPrecio.Text = "label6";
            // 
            // labelErrorAgregar
            // 
            this.labelErrorAgregar.AutoSize = true;
            this.labelErrorAgregar.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAgregar.Location = new System.Drawing.Point(610, 267);
            this.labelErrorAgregar.Name = "labelErrorAgregar";
            this.labelErrorAgregar.Size = new System.Drawing.Size(35, 13);
            this.labelErrorAgregar.TabIndex = 83;
            this.labelErrorAgregar.Text = "label6";
            // 
            // botonBorrar
            // 
            this.botonBorrar.ForeColor = System.Drawing.Color.Black;
            this.botonBorrar.Location = new System.Drawing.Point(372, 534);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(139, 34);
            this.botonBorrar.TabIndex = 84;
            this.botonBorrar.Text = "Borrar";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.Location = new System.Drawing.Point(432, 494);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(72, 25);
            this.labelT.TabIndex = 85;
            this.labelT.Text = "Total:";
            // 
            // labelPrecioTotal
            // 
            this.labelPrecioTotal.AutoSize = true;
            this.labelPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioTotal.Location = new System.Drawing.Point(510, 499);
            this.labelPrecioTotal.Name = "labelPrecioTotal";
            this.labelPrecioTotal.Size = new System.Drawing.Size(46, 18);
            this.labelPrecioTotal.TabIndex = 86;
            this.labelPrecioTotal.Text = "label6";
            // 
            // labelTrabajo
            // 
            this.labelTrabajo.AutoSize = true;
            this.labelTrabajo.Location = new System.Drawing.Point(173, 206);
            this.labelTrabajo.Name = "labelTrabajo";
            this.labelTrabajo.Size = new System.Drawing.Size(35, 13);
            this.labelTrabajo.TabIndex = 87;
            this.labelTrabajo.Text = "label7";
            // 
            // listaAutos
            // 
            this.listaAutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listaAutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaAutos.HideSelection = false;
            this.listaAutos.Location = new System.Drawing.Point(351, 64);
            this.listaAutos.Name = "listaAutos";
            this.listaAutos.Size = new System.Drawing.Size(326, 126);
            this.listaAutos.TabIndex = 89;
            this.listaAutos.UseCompatibleStateImageBehavior = false;
            this.listaAutos.View = System.Windows.Forms.View.Details;
            this.listaAutos.SelectedIndexChanged += new System.EventHandler(this.indexListaAutos_Changed);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Patente";
            this.columnHeader11.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Marca";
            this.columnHeader8.Width = 75;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Modelo";
            this.columnHeader9.Width = 75;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 90;
            this.label6.Text = "Trabajos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(498, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 91;
            this.label7.Text = "Autos";
            // 
            // botonBorrarAuto
            // 
            this.botonBorrarAuto.BackColor = System.Drawing.Color.Transparent;
            this.botonBorrarAuto.ForeColor = System.Drawing.Color.Black;
            this.botonBorrarAuto.Location = new System.Drawing.Point(597, 196);
            this.botonBorrarAuto.Name = "botonBorrarAuto";
            this.botonBorrarAuto.Size = new System.Drawing.Size(81, 23);
            this.botonBorrarAuto.TabIndex = 92;
            this.botonBorrarAuto.Text = "Borrar Auto";
            this.botonBorrarAuto.UseVisualStyleBackColor = false;
            this.botonBorrarAuto.Click += new System.EventHandler(this.botonBorrarAuto_Click);
            // 
            // labelErrorAgregarTrabajo
            // 
            this.labelErrorAgregarTrabajo.AutoSize = true;
            this.labelErrorAgregarTrabajo.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAgregarTrabajo.Location = new System.Drawing.Point(539, 518);
            this.labelErrorAgregarTrabajo.Name = "labelErrorAgregarTrabajo";
            this.labelErrorAgregarTrabajo.Size = new System.Drawing.Size(35, 13);
            this.labelErrorAgregarTrabajo.TabIndex = 93;
            this.labelErrorAgregarTrabajo.Text = "label6";
            // 
            // iconoAgregar
            // 
            this.iconoAgregar.ErrorImage = global::TallerXP.Properties.Resources.agregar;
            this.iconoAgregar.Image = global::TallerXP.Properties.Resources.agregar;
            this.iconoAgregar.Location = new System.Drawing.Point(656, 242);
            this.iconoAgregar.Name = "iconoAgregar";
            this.iconoAgregar.Size = new System.Drawing.Size(22, 23);
            this.iconoAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoAgregar.TabIndex = 79;
            this.iconoAgregar.TabStop = false;
            this.iconoAgregar.Click += new System.EventHandler(this.IconoAgregar_Click);
            // 
            // botonExcel
            // 
            this.botonExcel.Image = global::TallerXP.Properties.Resources.excelIco;
            this.botonExcel.Location = new System.Drawing.Point(632, 499);
            this.botonExcel.Name = "botonExcel";
            this.botonExcel.Size = new System.Drawing.Size(45, 30);
            this.botonExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonExcel.TabIndex = 94;
            this.botonExcel.TabStop = false;
            this.botonExcel.Click += new System.EventHandler(this.botonExcel_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(689, 579);
            this.Controls.Add(this.botonExcel);
            this.Controls.Add(this.labelErrorAgregarTrabajo);
            this.Controls.Add(this.botonBorrarAuto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listaAutos);
            this.Controls.Add(this.labelTrabajo);
            this.Controls.Add(this.labelPrecioTotal);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.labelErrorAgregar);
            this.Controls.Add(this.labelErrorPrecio);
            this.Controls.Add(this.labelErrorCantidad);
            this.Controls.Add(this.labelErrorDescripcion);
            this.Controls.Add(this.iconoAgregar);
            this.Controls.Add(this.botonCancelarTrabajo);
            this.Controls.Add(this.botonAgregarTrabajo);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.textboxSubtotal);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.textboxPrecio);
            this.Controls.Add(this.textboxCantidad);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textboxDescripcion);
            this.Controls.Add(this.botonNuevoTrabajo);
            this.Controls.Add(this.listaDetalleArreglo);
            this.Controls.Add(this.listaArreglos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconoAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listaArreglos;
        private System.Windows.Forms.ListView listaDetalleArreglo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button botonNuevoTrabajo;
        private System.Windows.Forms.TextBox textboxDescripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelCantidad;
       
        private System.Windows.Forms.Button botonAgregarTrabajo;
        private System.Windows.Forms.Button botonCancelarTrabajo;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.PictureBox iconoAgregar;
        private System.Windows.Forms.TextBox textboxCantidad;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textboxPrecio;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.TextBox textboxSubtotal;
        private System.Windows.Forms.Label labelErrorDescripcion;
        private System.Windows.Forms.Label labelErrorCantidad;
        private System.Windows.Forms.Label labelErrorPrecio;
        private System.Windows.Forms.Label labelErrorAgregar;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelPrecioTotal;
        private System.Windows.Forms.Label labelTrabajo;
        private System.Windows.Forms.ListView listaAutos;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botonBorrarAuto;
        private System.Windows.Forms.Label labelErrorAgregarTrabajo;
        private System.Windows.Forms.PictureBox botonExcel;
    }
}
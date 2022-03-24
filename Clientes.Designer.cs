
namespace Taller
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.botonNuevoCliente = new System.Windows.Forms.Button();
            this.listaClientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textboxDNI = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textboxNombre = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textboxApellido = new System.Windows.Forms.TextBox();
            this.botonAgregarCliente = new System.Windows.Forms.Button();
            this.labelErrorDNI = new System.Windows.Forms.Label();
            this.labelErrorNombre = new System.Windows.Forms.Label();
            this.labelErrorApellido = new System.Windows.Forms.Label();
            this.labelErrorAgregarCliente = new System.Windows.Forms.Label();
            this.labelExitoAgregarCliente = new System.Windows.Forms.Label();
            this.textboxBuscarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonEditarCliente = new System.Windows.Forms.Button();
            this.botonHistorialCliente = new System.Windows.Forms.Button();
            this.botonGuardarEditado = new System.Windows.Forms.Button();
            this.botonAgregarAuto = new System.Windows.Forms.Button();
            this.textboxMarca = new System.Windows.Forms.TextBox();
            this.textboxAnio = new System.Windows.Forms.TextBox();
            this.textboxModelo = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelAnio = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textboxPatente = new System.Windows.Forms.TextBox();
            this.labelPatente = new System.Windows.Forms.Label();
            this.botonOKAuto = new System.Windows.Forms.Button();
            this.labelErrorMarca = new System.Windows.Forms.Label();
            this.labelErrorAnio = new System.Windows.Forms.Label();
            this.labelErrorModelo = new System.Windows.Forms.Label();
            this.labelErrorPatente = new System.Windows.Forms.Label();
            this.labelErrorAuto = new System.Windows.Forms.Label();
            this.labelAutoAgregado = new System.Windows.Forms.Label();
            this.botonCancelarNuevoCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botonCancelarAuto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonNuevoCliente
            // 
            this.botonNuevoCliente.ForeColor = System.Drawing.Color.Black;
            this.botonNuevoCliente.Location = new System.Drawing.Point(624, 24);
            this.botonNuevoCliente.Name = "botonNuevoCliente";
            this.botonNuevoCliente.Size = new System.Drawing.Size(106, 22);
            this.botonNuevoCliente.TabIndex = 1;
            this.botonNuevoCliente.Text = "Nuevo Cliente";
            this.botonNuevoCliente.UseVisualStyleBackColor = true;
            this.botonNuevoCliente.Click += new System.EventHandler(this.botonNuevoCliente_Click);
            // 
            // listaClientes
            // 
            this.listaClientes.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listaClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaClientes.HideSelection = false;
            this.listaClientes.Location = new System.Drawing.Point(10, 100);
            this.listaClientes.MultiSelect = false;
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(454, 212);
            this.listaClientes.TabIndex = 2;
            this.listaClientes.UseCompatibleStateImageBehavior = false;
            this.listaClientes.View = System.Windows.Forms.View.Details;
            this.listaClientes.SelectedIndexChanged += new System.EventHandler(this.indexLista_Changed);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DNI";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha Creacion";
            this.columnHeader4.Width = 115;
            // 
            // textboxDNI
            // 
            this.textboxDNI.Location = new System.Drawing.Point(623, 82);
            this.textboxDNI.Name = "textboxDNI";
            this.textboxDNI.Size = new System.Drawing.Size(107, 20);
            this.textboxDNI.TabIndex = 4;
            this.textboxDNI.TextChanged += new System.EventHandler(this.textDNI_Changed);
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.ForeColor = System.Drawing.Color.Black;
            this.labelDNI.Location = new System.Drawing.Point(624, 64);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 5;
            this.labelDNI.Text = "DNI";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.Color.Black;
            this.labelNombre.Location = new System.Drawing.Point(624, 122);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre";
            // 
            // textboxNombre
            // 
            this.textboxNombre.Location = new System.Drawing.Point(624, 137);
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.Size = new System.Drawing.Size(107, 20);
            this.textboxNombre.TabIndex = 7;
            this.textboxNombre.TextChanged += new System.EventHandler(this.textNombre_Changed);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.ForeColor = System.Drawing.Color.Black;
            this.labelApellido.Location = new System.Drawing.Point(624, 181);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 8;
            this.labelApellido.Text = "Apellido";
            // 
            // textboxApellido
            // 
            this.textboxApellido.Location = new System.Drawing.Point(624, 197);
            this.textboxApellido.Name = "textboxApellido";
            this.textboxApellido.Size = new System.Drawing.Size(107, 20);
            this.textboxApellido.TabIndex = 9;
            this.textboxApellido.TextChanged += new System.EventHandler(this.textApellido_Changed);
            // 
            // botonAgregarCliente
            // 
            this.botonAgregarCliente.ForeColor = System.Drawing.Color.Black;
            this.botonAgregarCliente.Location = new System.Drawing.Point(620, 247);
            this.botonAgregarCliente.Name = "botonAgregarCliente";
            this.botonAgregarCliente.Size = new System.Drawing.Size(109, 20);
            this.botonAgregarCliente.TabIndex = 10;
            this.botonAgregarCliente.Text = "Agregar Cliente";
            this.botonAgregarCliente.UseVisualStyleBackColor = true;
            this.botonAgregarCliente.Click += new System.EventHandler(this.botonAgregarCliente_Click);
            // 
            // labelErrorDNI
            // 
            this.labelErrorDNI.AutoSize = true;
            this.labelErrorDNI.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDNI.Location = new System.Drawing.Point(624, 102);
            this.labelErrorDNI.Name = "labelErrorDNI";
            this.labelErrorDNI.Size = new System.Drawing.Size(35, 13);
            this.labelErrorDNI.TabIndex = 11;
            this.labelErrorDNI.Text = "label1";
            // 
            // labelErrorNombre
            // 
            this.labelErrorNombre.AutoSize = true;
            this.labelErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.labelErrorNombre.Location = new System.Drawing.Point(624, 160);
            this.labelErrorNombre.Name = "labelErrorNombre";
            this.labelErrorNombre.Size = new System.Drawing.Size(35, 13);
            this.labelErrorNombre.TabIndex = 12;
            this.labelErrorNombre.Text = "label1";
            // 
            // labelErrorApellido
            // 
            this.labelErrorApellido.AutoSize = true;
            this.labelErrorApellido.ForeColor = System.Drawing.Color.Red;
            this.labelErrorApellido.Location = new System.Drawing.Point(624, 220);
            this.labelErrorApellido.Name = "labelErrorApellido";
            this.labelErrorApellido.Size = new System.Drawing.Size(35, 13);
            this.labelErrorApellido.TabIndex = 13;
            this.labelErrorApellido.Text = "label1";
            // 
            // labelErrorAgregarCliente
            // 
            this.labelErrorAgregarCliente.AutoSize = true;
            this.labelErrorAgregarCliente.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAgregarCliente.Location = new System.Drawing.Point(606, 233);
            this.labelErrorAgregarCliente.Name = "labelErrorAgregarCliente";
            this.labelErrorAgregarCliente.Size = new System.Drawing.Size(35, 13);
            this.labelErrorAgregarCliente.TabIndex = 14;
            this.labelErrorAgregarCliente.Text = "label1";
            // 
            // labelExitoAgregarCliente
            // 
            this.labelExitoAgregarCliente.AutoSize = true;
            this.labelExitoAgregarCliente.ForeColor = System.Drawing.Color.Red;
            this.labelExitoAgregarCliente.Location = new System.Drawing.Point(624, 48);
            this.labelExitoAgregarCliente.Name = "labelExitoAgregarCliente";
            this.labelExitoAgregarCliente.Size = new System.Drawing.Size(35, 13);
            this.labelExitoAgregarCliente.TabIndex = 15;
            this.labelExitoAgregarCliente.Text = "label1";
            // 
            // textboxBuscarCliente
            // 
            this.textboxBuscarCliente.Location = new System.Drawing.Point(59, 77);
            this.textboxBuscarCliente.Name = "textboxBuscarCliente";
            this.textboxBuscarCliente.Size = new System.Drawing.Size(86, 20);
            this.textboxBuscarCliente.TabIndex = 16;
            this.textboxBuscarCliente.TextChanged += new System.EventHandler(this.textBuscarCliente_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar:";
            // 
            // botonEditarCliente
            // 
            this.botonEditarCliente.ForeColor = System.Drawing.Color.Black;
            this.botonEditarCliente.Location = new System.Drawing.Point(473, 122);
            this.botonEditarCliente.Name = "botonEditarCliente";
            this.botonEditarCliente.Size = new System.Drawing.Size(75, 20);
            this.botonEditarCliente.TabIndex = 18;
            this.botonEditarCliente.Text = "Editar";
            this.botonEditarCliente.UseVisualStyleBackColor = true;
            this.botonEditarCliente.Click += new System.EventHandler(this.botonEditarCliente_Click);
            // 
            // botonHistorialCliente
            // 
            this.botonHistorialCliente.ForeColor = System.Drawing.Color.Black;
            this.botonHistorialCliente.Location = new System.Drawing.Point(473, 156);
            this.botonHistorialCliente.Name = "botonHistorialCliente";
            this.botonHistorialCliente.Size = new System.Drawing.Size(75, 20);
            this.botonHistorialCliente.TabIndex = 19;
            this.botonHistorialCliente.Text = "Ver historial";
            this.botonHistorialCliente.UseVisualStyleBackColor = true;
            this.botonHistorialCliente.Click += new System.EventHandler(this.verHistorial_Click);
            // 
            // botonGuardarEditado
            // 
            this.botonGuardarEditado.ForeColor = System.Drawing.Color.Black;
            this.botonGuardarEditado.Location = new System.Drawing.Point(619, 249);
            this.botonGuardarEditado.Name = "botonGuardarEditado";
            this.botonGuardarEditado.Size = new System.Drawing.Size(110, 20);
            this.botonGuardarEditado.TabIndex = 20;
            this.botonGuardarEditado.Text = "Guardar Cambios";
            this.botonGuardarEditado.UseVisualStyleBackColor = true;
            this.botonGuardarEditado.Click += new System.EventHandler(this.botonGuardarEditado_Click);
            // 
            // botonAgregarAuto
            // 
            this.botonAgregarAuto.ForeColor = System.Drawing.Color.Black;
            this.botonAgregarAuto.Location = new System.Drawing.Point(473, 187);
            this.botonAgregarAuto.Name = "botonAgregarAuto";
            this.botonAgregarAuto.Size = new System.Drawing.Size(75, 38);
            this.botonAgregarAuto.TabIndex = 21;
            this.botonAgregarAuto.Text = "Agregar Auto";
            this.botonAgregarAuto.UseVisualStyleBackColor = true;
            this.botonAgregarAuto.Click += new System.EventHandler(this.botonAgregarAuto_Click);
            // 
            // textboxMarca
            // 
            this.textboxMarca.Location = new System.Drawing.Point(426, 334);
            this.textboxMarca.Name = "textboxMarca";
            this.textboxMarca.Size = new System.Drawing.Size(107, 20);
            this.textboxMarca.TabIndex = 22;
            this.textboxMarca.TextChanged += new System.EventHandler(this.marcaText_Changed);
            // 
            // textboxAnio
            // 
            this.textboxAnio.Location = new System.Drawing.Point(426, 384);
            this.textboxAnio.Name = "textboxAnio";
            this.textboxAnio.Size = new System.Drawing.Size(107, 20);
            this.textboxAnio.TabIndex = 23;
            this.textboxAnio.TextChanged += new System.EventHandler(this.anioText_Changed);
            // 
            // textboxModelo
            // 
            this.textboxModelo.Location = new System.Drawing.Point(557, 334);
            this.textboxModelo.Name = "textboxModelo";
            this.textboxModelo.Size = new System.Drawing.Size(107, 20);
            this.textboxModelo.TabIndex = 24;
            this.textboxModelo.TextChanged += new System.EventHandler(this.modeloText_Changed);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.ForeColor = System.Drawing.Color.Black;
            this.labelMarca.Location = new System.Drawing.Point(427, 315);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 25;
            this.labelMarca.Text = "Marca";
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.ForeColor = System.Drawing.Color.Black;
            this.labelAnio.Location = new System.Drawing.Point(427, 368);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(26, 13);
            this.labelAnio.TabIndex = 26;
            this.labelAnio.Text = "Año";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.ForeColor = System.Drawing.Color.Black;
            this.labelModelo.Location = new System.Drawing.Point(554, 315);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 27;
            this.labelModelo.Text = "Modelo";
            // 
            // textboxPatente
            // 
            this.textboxPatente.Location = new System.Drawing.Point(557, 384);
            this.textboxPatente.Name = "textboxPatente";
            this.textboxPatente.Size = new System.Drawing.Size(107, 20);
            this.textboxPatente.TabIndex = 28;
            this.textboxPatente.TextChanged += new System.EventHandler(this.patenteText_Changed);
            // 
            // labelPatente
            // 
            this.labelPatente.AutoSize = true;
            this.labelPatente.ForeColor = System.Drawing.Color.Black;
            this.labelPatente.Location = new System.Drawing.Point(554, 368);
            this.labelPatente.Name = "labelPatente";
            this.labelPatente.Size = new System.Drawing.Size(44, 13);
            this.labelPatente.TabIndex = 29;
            this.labelPatente.Text = "Patente";
            // 
            // botonOKAuto
            // 
            this.botonOKAuto.ForeColor = System.Drawing.Color.Black;
            this.botonOKAuto.Location = new System.Drawing.Point(679, 334);
            this.botonOKAuto.Name = "botonOKAuto";
            this.botonOKAuto.Size = new System.Drawing.Size(63, 47);
            this.botonOKAuto.TabIndex = 30;
            this.botonOKAuto.Text = "OK";
            this.botonOKAuto.UseVisualStyleBackColor = true;
            this.botonOKAuto.Click += new System.EventHandler(this.botonOKAuto_Click);
            // 
            // labelErrorMarca
            // 
            this.labelErrorMarca.AutoSize = true;
            this.labelErrorMarca.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMarca.Location = new System.Drawing.Point(429, 355);
            this.labelErrorMarca.Name = "labelErrorMarca";
            this.labelErrorMarca.Size = new System.Drawing.Size(35, 13);
            this.labelErrorMarca.TabIndex = 31;
            this.labelErrorMarca.Text = "label1";
            // 
            // labelErrorAnio
            // 
            this.labelErrorAnio.AutoSize = true;
            this.labelErrorAnio.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAnio.Location = new System.Drawing.Point(427, 407);
            this.labelErrorAnio.Name = "labelErrorAnio";
            this.labelErrorAnio.Size = new System.Drawing.Size(35, 13);
            this.labelErrorAnio.TabIndex = 32;
            this.labelErrorAnio.Text = "label1";
            // 
            // labelErrorModelo
            // 
            this.labelErrorModelo.AutoSize = true;
            this.labelErrorModelo.ForeColor = System.Drawing.Color.Red;
            this.labelErrorModelo.Location = new System.Drawing.Point(561, 355);
            this.labelErrorModelo.Name = "labelErrorModelo";
            this.labelErrorModelo.Size = new System.Drawing.Size(35, 13);
            this.labelErrorModelo.TabIndex = 33;
            this.labelErrorModelo.Text = "label1";
            // 
            // labelErrorPatente
            // 
            this.labelErrorPatente.AutoSize = true;
            this.labelErrorPatente.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPatente.Location = new System.Drawing.Point(561, 407);
            this.labelErrorPatente.Name = "labelErrorPatente";
            this.labelErrorPatente.Size = new System.Drawing.Size(35, 13);
            this.labelErrorPatente.TabIndex = 34;
            this.labelErrorPatente.Text = "label1";
            // 
            // labelErrorAuto
            // 
            this.labelErrorAuto.AutoSize = true;
            this.labelErrorAuto.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAuto.Location = new System.Drawing.Point(664, 407);
            this.labelErrorAuto.Name = "labelErrorAuto";
            this.labelErrorAuto.Size = new System.Drawing.Size(35, 13);
            this.labelErrorAuto.TabIndex = 35;
            this.labelErrorAuto.Text = "label1";
            // 
            // labelAutoAgregado
            // 
            this.labelAutoAgregado.AutoSize = true;
            this.labelAutoAgregado.ForeColor = System.Drawing.Color.Red;
            this.labelAutoAgregado.Location = new System.Drawing.Point(476, 228);
            this.labelAutoAgregado.Name = "labelAutoAgregado";
            this.labelAutoAgregado.Size = new System.Drawing.Size(35, 13);
            this.labelAutoAgregado.TabIndex = 36;
            this.labelAutoAgregado.Text = "label1";
            // 
            // botonCancelarNuevoCliente
            // 
            this.botonCancelarNuevoCliente.Location = new System.Drawing.Point(619, 273);
            this.botonCancelarNuevoCliente.Name = "botonCancelarNuevoCliente";
            this.botonCancelarNuevoCliente.Size = new System.Drawing.Size(109, 23);
            this.botonCancelarNuevoCliente.TabIndex = 37;
            this.botonCancelarNuevoCliente.Text = "Cancelar";
            this.botonCancelarNuevoCliente.UseVisualStyleBackColor = true;
            this.botonCancelarNuevoCliente.Click += new System.EventHandler(this.botonCancelarNuevoCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Matias Chedas®";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(741, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "V1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 31);
            this.label4.TabIndex = 40;
            this.label4.Text = "Taller XP";
            // 
            // botonCancelarAuto
            // 
            this.botonCancelarAuto.Location = new System.Drawing.Point(679, 384);
            this.botonCancelarAuto.Name = "botonCancelarAuto";
            this.botonCancelarAuto.Size = new System.Drawing.Size(63, 23);
            this.botonCancelarAuto.TabIndex = 41;
            this.botonCancelarAuto.Text = "Cancelar";
            this.botonCancelarAuto.UseVisualStyleBackColor = true;
            this.botonCancelarAuto.Click += new System.EventHandler(this.botonCancelarAuto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TallerXP.Properties.Resources.mecanico;
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(772, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonCancelarAuto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonCancelarNuevoCliente);
            this.Controls.Add(this.labelAutoAgregado);
            this.Controls.Add(this.labelErrorAuto);
            this.Controls.Add(this.labelErrorPatente);
            this.Controls.Add(this.labelErrorModelo);
            this.Controls.Add(this.labelErrorAnio);
            this.Controls.Add(this.labelErrorMarca);
            this.Controls.Add(this.botonOKAuto);
            this.Controls.Add(this.labelPatente);
            this.Controls.Add(this.textboxPatente);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelAnio);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textboxModelo);
            this.Controls.Add(this.textboxAnio);
            this.Controls.Add(this.textboxMarca);
            this.Controls.Add(this.botonAgregarAuto);
            this.Controls.Add(this.botonGuardarEditado);
            this.Controls.Add(this.botonHistorialCliente);
            this.Controls.Add(this.botonEditarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxBuscarCliente);
            this.Controls.Add(this.labelExitoAgregarCliente);
            this.Controls.Add(this.labelErrorAgregarCliente);
            this.Controls.Add(this.labelErrorApellido);
            this.Controls.Add(this.labelErrorNombre);
            this.Controls.Add(this.labelErrorDNI);
            this.Controls.Add(this.botonAgregarCliente);
            this.Controls.Add(this.textboxApellido);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textboxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.textboxDNI);
            this.Controls.Add(this.listaClientes);
            this.Controls.Add(this.botonNuevoCliente);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.Text = "Taller XP v1.0";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonNuevoCliente;
        private System.Windows.Forms.ListView listaClientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textboxDNI;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textboxNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textboxApellido;
        private System.Windows.Forms.Button botonAgregarCliente;
        private System.Windows.Forms.Label labelErrorDNI;
        private System.Windows.Forms.Label labelErrorNombre;
        private System.Windows.Forms.Label labelErrorApellido;
        private System.Windows.Forms.Label labelErrorAgregarCliente;
        private System.Windows.Forms.Label labelExitoAgregarCliente;
        private System.Windows.Forms.TextBox textboxBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonEditarCliente;
        private System.Windows.Forms.Button botonHistorialCliente;
        private System.Windows.Forms.Button botonGuardarEditado;
        private System.Windows.Forms.Button botonAgregarAuto;
        private System.Windows.Forms.TextBox textboxMarca;
        private System.Windows.Forms.TextBox textboxAnio;
        private System.Windows.Forms.TextBox textboxModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelAnio;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textboxPatente;
        private System.Windows.Forms.Label labelPatente;
        private System.Windows.Forms.Button botonOKAuto;
        private System.Windows.Forms.Label labelErrorMarca;
        private System.Windows.Forms.Label labelErrorAnio;
        private System.Windows.Forms.Label labelErrorModelo;
        private System.Windows.Forms.Label labelErrorPatente;
        private System.Windows.Forms.Label labelErrorAuto;
        private System.Windows.Forms.Label labelAutoAgregado;
        private System.Windows.Forms.Button botonCancelarNuevoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonCancelarAuto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
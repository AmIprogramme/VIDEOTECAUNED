namespace Servidor.Capa_de_presentacion.Consultas
{
    partial class Consulta_de_prestamos
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
            tabla = new DataGridView();
            IdPrestamo = new DataGridViewTextBoxColumn();
            IdCliente = new DataGridViewTextBoxColumn();
            IdSucursal = new DataGridViewTextBoxColumn();
            IdPelicula = new DataGridViewTextBoxColumn();
            FechaPrestamo = new DataGridViewTextBoxColumn();
            PendienteDevolucion = new DataGridViewTextBoxColumn();
            label4 = new Label();
            comboBox_de_identificaciones = new ComboBox();
            label1 = new Label();
            campo_de_nombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // tabla
            // 
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { IdPrestamo, IdCliente, IdSucursal, IdPelicula, FechaPrestamo, PendienteDevolucion });
            tabla.Location = new Point(35, 171);
            tabla.Name = "tabla";
            tabla.ReadOnly = true;
            tabla.Size = new Size(964, 283);
            tabla.TabIndex = 0;
            // 
            // IdPrestamo
            // 
            IdPrestamo.HeaderText = "Id de prestamo";
            IdPrestamo.Name = "IdPrestamo";
            IdPrestamo.ReadOnly = true;
            IdPrestamo.Width = 140;
            // 
            // IdCliente
            // 
            IdCliente.HeaderText = "Id de cliente";
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            IdCliente.Width = 160;
            // 
            // IdSucursal
            // 
            IdSucursal.HeaderText = "Id de sucursal";
            IdSucursal.Name = "IdSucursal";
            IdSucursal.ReadOnly = true;
            IdSucursal.Width = 170;
            // 
            // IdPelicula
            // 
            IdPelicula.HeaderText = "Id de película";
            IdPelicula.Name = "IdPelicula";
            IdPelicula.ReadOnly = true;
            IdPelicula.Width = 150;
            // 
            // FechaPrestamo
            // 
            FechaPrestamo.HeaderText = "Fecha de prestamo";
            FechaPrestamo.Name = "FechaPrestamo";
            FechaPrestamo.ReadOnly = true;
            FechaPrestamo.Width = 200;
            // 
            // PendienteDevolucion
            // 
            PendienteDevolucion.HeaderText = "Pendiente de devolución";
            PendienteDevolucion.Name = "PendienteDevolucion";
            PendienteDevolucion.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 73);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(211, 24);
            label4.TabIndex = 9;
            label4.Text = "Identificación de cliente:";
            // 
            // comboBox_de_identificaciones
            // 
            comboBox_de_identificaciones.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_de_identificaciones.FormattingEnabled = true;
            comboBox_de_identificaciones.Location = new Point(254, 73);
            comboBox_de_identificaciones.Margin = new Padding(4, 3, 4, 3);
            comboBox_de_identificaciones.Name = "comboBox_de_identificaciones";
            comboBox_de_identificaciones.Size = new Size(128, 28);
            comboBox_de_identificaciones.TabIndex = 8;
            comboBox_de_identificaciones.SelectedIndexChanged += comboBox_de_identificaciones_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(415, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 24);
            label1.TabIndex = 10;
            label1.Text = "Nombre:";
            // 
            // campo_de_nombre
            // 
            campo_de_nombre.Location = new Point(518, 27);
            campo_de_nombre.Margin = new Padding(4, 3, 4, 3);
            campo_de_nombre.Multiline = true;
            campo_de_nombre.Name = "campo_de_nombre";
            campo_de_nombre.ReadOnly = true;
            campo_de_nombre.Size = new Size(314, 31);
            campo_de_nombre.TabIndex = 11;
            // 
            // Consulta_de_prestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 485);
            Controls.Add(label1);
            Controls.Add(campo_de_nombre);
            Controls.Add(label4);
            Controls.Add(comboBox_de_identificaciones);
            Controls.Add(tabla);
            Name = "Consulta_de_prestamos";
            Text = "Consulta_de_prestamos";
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabla;
        private DataGridViewTextBoxColumn IdPrestamo;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn IdSucursal;
        private DataGridViewTextBoxColumn IdPelicula;
        private DataGridViewTextBoxColumn FechaPrestamo;
        private DataGridViewTextBoxColumn PendienteDevolucion;
        private Label label4;
        private ComboBox comboBox_de_identificaciones;
        private Label label1;
        private TextBox campo_de_nombre;
    }
}
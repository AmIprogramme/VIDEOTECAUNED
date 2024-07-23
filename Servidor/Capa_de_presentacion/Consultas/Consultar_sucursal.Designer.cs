namespace Servidor
{
    partial class Consultar_sucursal
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
            tabla_de_contenidos = new DataGridView();
            id_sucursal = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            encargado = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabla_de_contenidos).BeginInit();
            SuspendLayout();
            // 
            // tabla_de_contenidos
            // 
            tabla_de_contenidos.AllowUserToAddRows = false;
            tabla_de_contenidos.AllowUserToDeleteRows = false;
            tabla_de_contenidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_de_contenidos.Columns.AddRange(new DataGridViewColumn[] { id_sucursal, nombre, encargado, direccion, telefono, estado });
            tabla_de_contenidos.Location = new Point(88, 74);
            tabla_de_contenidos.Margin = new Padding(4, 3, 4, 3);
            tabla_de_contenidos.Name = "tabla_de_contenidos";
            tabla_de_contenidos.ReadOnly = true;
            tabla_de_contenidos.Size = new Size(924, 411);
            tabla_de_contenidos.TabIndex = 0;
            // 
            // id_sucursal
            // 
            id_sucursal.HeaderText = "Identificación de sucursal";
            id_sucursal.Name = "id_sucursal";
            id_sucursal.ReadOnly = true;
            id_sucursal.Width = 140;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 120;
            // 
            // encargado
            // 
            encargado.HeaderText = "Encargado";
            encargado.Name = "encargado";
            encargado.ReadOnly = true;
            encargado.Width = 170;
            // 
            // direccion
            // 
            direccion.HeaderText = "Dirección";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            direccion.Width = 250;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // estado
            // 
            estado.HeaderText = "Activo";
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // Consultar_sucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 556);
            Controls.Add(tabla_de_contenidos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Consultar_sucursal";
            Text = "Consultar_sucursal";
            ((System.ComponentModel.ISupportInitialize)tabla_de_contenidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_de_contenidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}
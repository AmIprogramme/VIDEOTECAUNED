namespace Servidor
{
    partial class Consultar_cliente
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
            Id = new DataGridViewTextBoxColumn();
            identificacion = new DataGridViewTextBoxColumn();
            primero_apellido = new DataGridViewTextBoxColumn();
            nacimiento = new DataGridViewTextBoxColumn();
            ingreso = new DataGridViewTextBoxColumn();
            activo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabla_de_contenidos).BeginInit();
            SuspendLayout();
            // 
            // tabla_de_contenidos
            // 
            tabla_de_contenidos.AllowUserToAddRows = false;
            tabla_de_contenidos.AllowUserToDeleteRows = false;
            tabla_de_contenidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_de_contenidos.Columns.AddRange(new DataGridViewColumn[] { Id, identificacion, primero_apellido, nacimiento, ingreso, activo });
            tabla_de_contenidos.Location = new Point(15, 65);
            tabla_de_contenidos.Margin = new Padding(4, 3, 4, 3);
            tabla_de_contenidos.Name = "tabla_de_contenidos";
            tabla_de_contenidos.Size = new Size(1022, 415);
            tabla_de_contenidos.TabIndex = 0;
            // 
            // Id
            // 
            Id.Frozen = true;
            Id.HeaderText = "Id cliente";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 140;
            // 
            // identificacion
            // 
            identificacion.Frozen = true;
            identificacion.HeaderText = "Identificación";
            identificacion.Name = "identificacion";
            identificacion.ReadOnly = true;
            identificacion.Width = 170;
            // 
            // primero_apellido
            // 
            primero_apellido.Frozen = true;
            primero_apellido.HeaderText = "Nombre completo";
            primero_apellido.Name = "primero_apellido";
            primero_apellido.ReadOnly = true;
            primero_apellido.Width = 240;
            // 
            // nacimiento
            // 
            nacimiento.Frozen = true;
            nacimiento.HeaderText = "Fecha de nacimiento";
            nacimiento.Name = "nacimiento";
            nacimiento.ReadOnly = true;
            nacimiento.Width = 200;
            // 
            // ingreso
            // 
            ingreso.Frozen = true;
            ingreso.HeaderText = "Fecha de ingreso";
            ingreso.Name = "ingreso";
            ingreso.ReadOnly = true;
            ingreso.Width = 150;
            // 
            // activo
            // 
            activo.Frozen = true;
            activo.HeaderText = "Activo";
            activo.Name = "activo";
            activo.ReadOnly = true;
            // 
            // Consultar_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 541);
            Controls.Add(tabla_de_contenidos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Consultar_cliente";
            Text = "Consultar_cliente";
            ((System.ComponentModel.ISupportInitialize)tabla_de_contenidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_de_contenidos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn identificacion;
        private DataGridViewTextBoxColumn primero_apellido;
        private DataGridViewTextBoxColumn nacimiento;
        private DataGridViewTextBoxColumn ingreso;
        private DataGridViewTextBoxColumn activo;
    }
}
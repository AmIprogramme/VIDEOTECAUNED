namespace Servidor
{
    partial class Consultar_encargado
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
            tabla_de_registros = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            identificacion = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            primer_apellido = new DataGridViewTextBoxColumn();
            segundo_apellido = new DataGridViewTextBoxColumn();
            nacimiento = new DataGridViewTextBoxColumn();
            ingreso = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabla_de_registros).BeginInit();
            SuspendLayout();
            // 
            // tabla_de_registros
            // 
            tabla_de_registros.AllowUserToAddRows = false;
            tabla_de_registros.AllowUserToDeleteRows = false;
            tabla_de_registros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_de_registros.Columns.AddRange(new DataGridViewColumn[] { id, identificacion, nombre, primer_apellido, segundo_apellido, nacimiento, ingreso });
            tabla_de_registros.Location = new Point(78, 135);
            tabla_de_registros.Margin = new Padding(4, 3, 4, 3);
            tabla_de_registros.Name = "tabla_de_registros";
            tabla_de_registros.ReadOnly = true;
            tabla_de_registros.Size = new Size(935, 346);
            tabla_de_registros.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "Id de empleado";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 150;
            // 
            // identificacion
            // 
            identificacion.HeaderText = "Identificación";
            identificacion.Name = "identificacion";
            identificacion.ReadOnly = true;
            identificacion.Width = 120;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // primer_apellido
            // 
            primer_apellido.HeaderText = "Primer apellido";
            primer_apellido.Name = "primer_apellido";
            primer_apellido.ReadOnly = true;
            primer_apellido.Width = 130;
            // 
            // segundo_apellido
            // 
            segundo_apellido.HeaderText = "Segundo apellido";
            segundo_apellido.Name = "segundo_apellido";
            segundo_apellido.ReadOnly = true;
            segundo_apellido.Width = 130;
            // 
            // nacimiento
            // 
            nacimiento.HeaderText = "Fecha de nacimiento";
            nacimiento.Name = "nacimiento";
            nacimiento.ReadOnly = true;
            nacimiento.Width = 130;
            // 
            // ingreso
            // 
            ingreso.HeaderText = "Fecha de ingreso";
            ingreso.Name = "ingreso";
            ingreso.ReadOnly = true;
            ingreso.Width = 130;
            // 
            // Consultar_encargado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 543);
            Controls.Add(tabla_de_registros);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Consultar_encargado";
            Text = "Consultar_encargado";
            ((System.ComponentModel.ISupportInitialize)tabla_de_registros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_de_registros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn primer_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundo_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingreso;
    }
}
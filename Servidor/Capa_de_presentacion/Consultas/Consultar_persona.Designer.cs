namespace Servidor
{
    partial class Consultar_persona
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
            identificacion = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            primer_apellido = new DataGridViewTextBoxColumn();
            segundo_apellido = new DataGridViewTextBoxColumn();
            nacimiento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabla_de_registros).BeginInit();
            SuspendLayout();
            // 
            // tabla_de_registros
            // 
            tabla_de_registros.AllowUserToAddRows = false;
            tabla_de_registros.AllowUserToDeleteRows = false;
            tabla_de_registros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_de_registros.Columns.AddRange(new DataGridViewColumn[] { identificacion, nombre, primer_apellido, segundo_apellido, nacimiento });
            tabla_de_registros.Location = new Point(38, 159);
            tabla_de_registros.Margin = new Padding(4, 3, 4, 3);
            tabla_de_registros.Name = "tabla_de_registros";
            tabla_de_registros.ReadOnly = true;
            tabla_de_registros.Size = new Size(993, 346);
            tabla_de_registros.TabIndex = 0;
            // 
            // identificacion
            // 
            identificacion.HeaderText = "Identificación";
            identificacion.Name = "identificacion";
            identificacion.ReadOnly = true;
            identificacion.Width = 180;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 200;
            // 
            // primer_apellido
            // 
            primer_apellido.HeaderText = "Primer apellido";
            primer_apellido.Name = "primer_apellido";
            primer_apellido.ReadOnly = true;
            primer_apellido.Width = 200;
            // 
            // segundo_apellido
            // 
            segundo_apellido.HeaderText = "Segundo apellido";
            segundo_apellido.Name = "segundo_apellido";
            segundo_apellido.ReadOnly = true;
            segundo_apellido.Width = 200;
            // 
            // nacimiento
            // 
            nacimiento.HeaderText = "Fecha de nacimiento";
            nacimiento.Name = "nacimiento";
            nacimiento.ReadOnly = true;
            nacimiento.Width = 170;
            // 
            // Consultar_persona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 543);
            Controls.Add(tabla_de_registros);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Consultar_persona";
            Text = "Consultar_encargado";
            ((System.ComponentModel.ISupportInitialize)tabla_de_registros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_de_registros;
        private DataGridViewTextBoxColumn identificacion;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn primer_apellido;
        private DataGridViewTextBoxColumn segundo_apellido;
        private DataGridViewTextBoxColumn nacimiento;
    }
}
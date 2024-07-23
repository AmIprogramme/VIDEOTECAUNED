namespace Servidor
{
    partial class Consultar_categoria
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
            tabla_de_categoria = new DataGridView();
            Id_de_categoria = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabla_de_categoria).BeginInit();
            SuspendLayout();
            // 
            // tabla_de_categoria
            // 
            tabla_de_categoria.AllowUserToAddRows = false;
            tabla_de_categoria.AllowUserToDeleteRows = false;
            tabla_de_categoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabla_de_categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_de_categoria.Columns.AddRange(new DataGridViewColumn[] { Id_de_categoria, nombre, descripcion });
            tabla_de_categoria.Location = new Point(54, 49);
            tabla_de_categoria.Margin = new Padding(4, 3, 4, 3);
            tabla_de_categoria.Name = "tabla_de_categoria";
            tabla_de_categoria.ReadOnly = true;
            tabla_de_categoria.Size = new Size(831, 418);
            tabla_de_categoria.TabIndex = 0;
            // 
            // Id_de_categoria
            // 
            Id_de_categoria.Frozen = true;
            Id_de_categoria.HeaderText = "Identificación de categoría";
            Id_de_categoria.Name = "Id_de_categoria";
            Id_de_categoria.ReadOnly = true;
            Id_de_categoria.Width = 200;
            // 
            // nombre
            // 
            nombre.Frozen = true;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 230;
            // 
            // descripcion
            // 
            descripcion.Frozen = true;
            descripcion.HeaderText = "Descripción";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 360;
            // 
            // Consultar_categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(tabla_de_categoria);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Consultar_categoria";
            Text = "Consultar_categoria";
            ((System.ComponentModel.ISupportInitialize)tabla_de_categoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_de_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_de_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}
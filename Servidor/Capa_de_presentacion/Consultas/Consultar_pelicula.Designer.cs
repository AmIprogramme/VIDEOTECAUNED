namespace Servidor { 
    partial class Consultar_pelicula
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
            titulo = new DataGridViewTextBoxColumn();
            categoria_de_pelicula = new DataGridViewTextBoxColumn();
            anio = new DataGridViewTextBoxColumn();
            idioma = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabla_de_registros).BeginInit();
            SuspendLayout();
            // 
            // tabla_de_registros
            // 
            tabla_de_registros.AllowUserToAddRows = false;
            tabla_de_registros.AllowUserToDeleteRows = false;
            tabla_de_registros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_de_registros.Columns.AddRange(new DataGridViewColumn[] { id, titulo, categoria_de_pelicula, anio, idioma });
            tabla_de_registros.Location = new Point(89, 93);
            tabla_de_registros.Margin = new Padding(4, 3, 4, 3);
            tabla_de_registros.Name = "tabla_de_registros";
            tabla_de_registros.ReadOnly = true;
            tabla_de_registros.Size = new Size(842, 342);
            tabla_de_registros.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "Id de película";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 140;
            // 
            // titulo
            // 
            titulo.HeaderText = "Titulo";
            titulo.Name = "titulo";
            titulo.ReadOnly = true;
            titulo.Width = 180;
            // 
            // categoria_de_pelicula
            // 
            categoria_de_pelicula.HeaderText = "Categoría ";
            categoria_de_pelicula.Name = "categoria_de_pelicula";
            categoria_de_pelicula.ReadOnly = true;
            categoria_de_pelicula.Width = 180;
            // 
            // anio
            // 
            anio.HeaderText = "Año";
            anio.Name = "anio";
            anio.ReadOnly = true;
            // 
            // idioma
            // 
            idioma.HeaderText = "Idioma";
            idioma.Name = "idioma";
            idioma.ReadOnly = true;
            idioma.Width = 200;
            // 
            // Consultar_pelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 542);
            Controls.Add(tabla_de_registros);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Consultar_pelicula";
            Text = "Consultar_pelicula";
            ((System.ComponentModel.ISupportInitialize)tabla_de_registros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_de_registros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria_de_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idioma;
    }
}
namespace Servidor
{
    partial class Consultar_peliculaxSucursal
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
            Id_sucursal = new DataGridViewTextBoxColumn();
            Nombre_sucursal = new DataGridViewTextBoxColumn();
            encargado = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            Id_categoria = new DataGridViewTextBoxColumn();
            categoria_de_pelicula = new DataGridViewTextBoxColumn();
            anio = new DataGridViewTextBoxColumn();
            idioma = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // tabla
            // 
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { Id_sucursal, Nombre_sucursal, encargado, id, titulo, Id_categoria, categoria_de_pelicula, anio, idioma });
            tabla.Location = new Point(13, 31);
            tabla.Margin = new Padding(4, 3, 4, 3);
            tabla.Name = "tabla";
            tabla.ReadOnly = true;
            tabla.Size = new Size(1223, 479);
            tabla.TabIndex = 1;
            // 
            // Id_sucursal
            // 
            Id_sucursal.HeaderText = "Id sucursal";
            Id_sucursal.Name = "Id_sucursal";
            Id_sucursal.ReadOnly = true;
            // 
            // Nombre_sucursal
            // 
            Nombre_sucursal.HeaderText = "N. Sucursal";
            Nombre_sucursal.Name = "Nombre_sucursal";
            Nombre_sucursal.ReadOnly = true;
            // 
            // encargado
            // 
            encargado.HeaderText = "N. Encargado";
            encargado.Name = "encargado";
            encargado.ReadOnly = true;
            encargado.Width = 200;
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
            titulo.HeaderText = "Titulo de película";
            titulo.Name = "titulo";
            titulo.ReadOnly = true;
            titulo.Width = 180;
            // 
            // Id_categoria
            // 
            Id_categoria.HeaderText = "Id de categoría";
            Id_categoria.Name = "Id_categoria";
            Id_categoria.ReadOnly = true;
            // 
            // categoria_de_pelicula
            // 
            categoria_de_pelicula.HeaderText = "Nombre de categoría ";
            categoria_de_pelicula.Name = "categoria_de_pelicula";
            categoria_de_pelicula.ReadOnly = true;
            categoria_de_pelicula.Width = 180;
            // 
            // anio
            // 
            anio.HeaderText = "Año";
            anio.Name = "anio";
            anio.ReadOnly = true;
            anio.Width = 90;
            // 
            // idioma
            // 
            idioma.HeaderText = "Idioma";
            idioma.Name = "idioma";
            idioma.ReadOnly = true;
            idioma.Width = 90;
            // 
            // Consultar_peliculaxSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 567);
            Controls.Add(tabla);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Consultar_peliculaxSucursal";
            Text = "Consultar pelicula por sucursal";
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView tabla;
        
        private DataGridViewTextBoxColumn Id_sucursal;
        private DataGridViewTextBoxColumn Nombre_sucursal;
        private DataGridViewTextBoxColumn encargado;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn Id_categoria;
        private DataGridViewTextBoxColumn categoria_de_pelicula;
        private DataGridViewTextBoxColumn anio;
        private DataGridViewTextBoxColumn idioma;
    }
}
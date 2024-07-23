namespace Usuario.Interfaces
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
            tabla_de_historial = new System.Windows.Forms.DataGridView();
            id_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Titulo_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lenguaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Fecha_prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            campo_nombre = new System.Windows.Forms.TextBox();
            Campo_S_Apellido = new System.Windows.Forms.TextBox();
            campo_P_Apellido = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)tabla_de_historial).BeginInit();
            SuspendLayout();
            // 
            // tabla_de_historial
            // 
            tabla_de_historial.AllowUserToAddRows = false;
            tabla_de_historial.AllowUserToDeleteRows = false;
            tabla_de_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_de_historial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id_pelicula, Titulo_pelicula, Anio, lenguaje, Id_categoria, nombre_categoria, Fecha_prestamo, pendiente });
            tabla_de_historial.Location = new System.Drawing.Point(106, 178);
            tabla_de_historial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabla_de_historial.Name = "tabla_de_historial";
            tabla_de_historial.ReadOnly = true;
            tabla_de_historial.Size = new System.Drawing.Size(893, 329);
            tabla_de_historial.TabIndex = 0;
            // 
            // id_pelicula
            // 
            id_pelicula.HeaderText = "Id de película";
            id_pelicula.Name = "id_pelicula";
            id_pelicula.ReadOnly = true;
            // 
            // Titulo_pelicula
            // 
            Titulo_pelicula.HeaderText = "Titulo de película";
            Titulo_pelicula.Name = "Titulo_pelicula";
            Titulo_pelicula.ReadOnly = true;
            Titulo_pelicula.Width = 150;
            // 
            // Anio
            // 
            Anio.HeaderText = "Año";
            Anio.Name = "Anio";
            Anio.ReadOnly = true;
            Anio.Width = 80;
            // 
            // lenguaje
            // 
            lenguaje.HeaderText = "Idioma";
            lenguaje.Name = "lenguaje";
            lenguaje.ReadOnly = true;
            // 
            // Id_categoria
            // 
            Id_categoria.HeaderText = "Id categoría";
            Id_categoria.Name = "Id_categoria";
            Id_categoria.ReadOnly = true;
            Id_categoria.Width = 80;
            // 
            // nombre_categoria
            // 
            nombre_categoria.HeaderText = "N. Categoría";
            nombre_categoria.Name = "nombre_categoria";
            nombre_categoria.ReadOnly = true;
            nombre_categoria.Width = 140;
            // 
            // Fecha_prestamo
            // 
            Fecha_prestamo.HeaderText = "Fecha de préstamo";
            Fecha_prestamo.Name = "Fecha_prestamo";
            Fecha_prestamo.ReadOnly = true;
            // 
            // pendiente
            // 
            pendiente.HeaderText = "Pendiente de devolución";
            pendiente.Name = "pendiente";
            pendiente.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(59, 20);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 20);
            label1.TabIndex = 13;
            label1.Text = "Nombre:";
            // 
            // campo_nombre
            // 
            campo_nombre.Location = new System.Drawing.Point(167, 22);
            campo_nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            campo_nombre.Name = "campo_nombre";
            campo_nombre.ReadOnly = true;
            campo_nombre.Size = new System.Drawing.Size(191, 23);
            campo_nombre.TabIndex = 14;
            // 
            // Campo_S_Apellido
            // 
            Campo_S_Apellido.Location = new System.Drawing.Point(167, 108);
            Campo_S_Apellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Campo_S_Apellido.Name = "Campo_S_Apellido";
            Campo_S_Apellido.ReadOnly = true;
            Campo_S_Apellido.Size = new System.Drawing.Size(191, 23);
            Campo_S_Apellido.TabIndex = 15;
            // 
            // campo_P_Apellido
            // 
            campo_P_Apellido.Location = new System.Drawing.Point(167, 65);
            campo_P_Apellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            campo_P_Apellido.Name = "campo_P_Apellido";
            campo_P_Apellido.ReadOnly = true;
            campo_P_Apellido.Size = new System.Drawing.Size(191, 23);
            campo_P_Apellido.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(59, 62);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 20);
            label2.TabIndex = 17;
            label2.Text = "1° Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(59, 108);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 20);
            label3.TabIndex = 18;
            label3.Text = "2° Apellido:";
            // 
            // Historial
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1080, 519);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(campo_P_Apellido);
            Controls.Add(Campo_S_Apellido);
            Controls.Add(campo_nombre);
            Controls.Add(label1);
            Controls.Add(tabla_de_historial);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Historial";
            Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)tabla_de_historial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_de_historial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campo_nombre;
        private System.Windows.Forms.TextBox Campo_S_Apellido;
        private System.Windows.Forms.TextBox campo_P_Apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenguaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendiente;
    }
}
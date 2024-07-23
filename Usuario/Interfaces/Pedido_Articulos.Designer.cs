namespace Usuario.Interfaces
{
    partial class Pedido_Articulos
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            campo_de_nombre = new System.Windows.Forms.TextBox();
            campo_de_direccion = new System.Windows.Forms.TextBox();
            campo_de_telefono = new System.Windows.Forms.TextBox();
            comboBox_de_sucursales = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            tabla_de_pedidos = new System.Windows.Forms.DataGridView();
            Id_de_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Nombre_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Agregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            label5 = new System.Windows.Forms.Label();
            btn_guardar = new System.Windows.Forms.Button();
            groupBox_de_registros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)tabla_de_pedidos).BeginInit();
            groupBox_de_registros.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(10, 94);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(10, 137);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 24);
            label2.TabIndex = 1;
            label2.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(10, 242);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 24);
            label3.TabIndex = 2;
            label3.Text = "Teléfono:";
            // 
            // campo_de_nombre
            // 
            campo_de_nombre.Location = new System.Drawing.Point(113, 94);
            campo_de_nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            campo_de_nombre.Multiline = true;
            campo_de_nombre.Name = "campo_de_nombre";
            campo_de_nombre.ReadOnly = true;
            campo_de_nombre.Size = new System.Drawing.Size(230, 31);
            campo_de_nombre.TabIndex = 3;
            // 
            // campo_de_direccion
            // 
            campo_de_direccion.Location = new System.Drawing.Point(113, 137);
            campo_de_direccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            campo_de_direccion.Multiline = true;
            campo_de_direccion.Name = "campo_de_direccion";
            campo_de_direccion.ReadOnly = true;
            campo_de_direccion.Size = new System.Drawing.Size(230, 85);
            campo_de_direccion.TabIndex = 4;
            // 
            // campo_de_telefono
            // 
            campo_de_telefono.Location = new System.Drawing.Point(113, 242);
            campo_de_telefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            campo_de_telefono.Multiline = true;
            campo_de_telefono.Name = "campo_de_telefono";
            campo_de_telefono.ReadOnly = true;
            campo_de_telefono.Size = new System.Drawing.Size(230, 31);
            campo_de_telefono.TabIndex = 5;
            // 
            // comboBox_de_sucursales
            // 
            comboBox_de_sucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBox_de_sucursales.FormattingEnabled = true;
            comboBox_de_sucursales.Location = new System.Drawing.Point(103, 22);
            comboBox_de_sucursales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_de_sucursales.Name = "comboBox_de_sucursales";
            comboBox_de_sucursales.Size = new System.Drawing.Size(128, 28);
            comboBox_de_sucursales.TabIndex = 6;
            comboBox_de_sucursales.SelectedIndexChanged += comboBox_de_hoteles_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(7, 22);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 24);
            label4.TabIndex = 7;
            label4.Text = "Sucursal:";
            // 
            // tabla_de_pedidos
            // 
            tabla_de_pedidos.AllowUserToAddRows = false;
            tabla_de_pedidos.AllowUserToDeleteRows = false;
            tabla_de_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_de_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id_de_pelicula, Titulo, anio, Idioma, Nombre_categoria, Agregar });
            tabla_de_pedidos.Location = new System.Drawing.Point(365, 58);
            tabla_de_pedidos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabla_de_pedidos.Name = "tabla_de_pedidos";
            tabla_de_pedidos.Size = new System.Drawing.Size(709, 253);
            tabla_de_pedidos.TabIndex = 8;
            tabla_de_pedidos.CellContentClick += tabla_de_pedidos_CellContentClick;
            // 
            // Id_de_pelicula
            // 
            Id_de_pelicula.Frozen = true;
            Id_de_pelicula.HeaderText = "Id de película";
            Id_de_pelicula.Name = "Id_de_pelicula";
            // 
            // Titulo
            // 
            Titulo.Frozen = true;
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
            // 
            // anio
            // 
            anio.Frozen = true;
            anio.HeaderText = "Año";
            anio.Name = "anio";
            // 
            // Idioma
            // 
            Idioma.Frozen = true;
            Idioma.HeaderText = "Idioma";
            Idioma.Name = "Idioma";
            // 
            // Nombre_categoria
            // 
            Nombre_categoria.Frozen = true;
            Nombre_categoria.HeaderText = "N. Categoría";
            Nombre_categoria.Name = "Nombre_categoria";
            // 
            // Agregar
            // 
            Agregar.Frozen = true;
            Agregar.HeaderText = "Seleccionar";
            Agregar.Name = "Agregar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(463, 10);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(276, 24);
            label5.TabIndex = 9;
            label5.Text = "Seleccione la película a préstar:";
            // 
            // btn_guardar
            // 
            btn_guardar.Enabled = false;
            btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_guardar.Location = new System.Drawing.Point(8, 320);
            btn_guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new System.Drawing.Size(173, 55);
            btn_guardar.TabIndex = 12;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // groupBox_de_registros
            // 
            groupBox_de_registros.Controls.Add(tabla_de_pedidos);
            groupBox_de_registros.Controls.Add(btn_guardar);
            groupBox_de_registros.Controls.Add(label1);
            groupBox_de_registros.Controls.Add(label2);
            groupBox_de_registros.Controls.Add(label3);
            groupBox_de_registros.Controls.Add(label5);
            groupBox_de_registros.Controls.Add(campo_de_nombre);
            groupBox_de_registros.Controls.Add(campo_de_direccion);
            groupBox_de_registros.Controls.Add(label4);
            groupBox_de_registros.Controls.Add(campo_de_telefono);
            groupBox_de_registros.Controls.Add(comboBox_de_sucursales);
            groupBox_de_registros.Location = new System.Drawing.Point(5, 12);
            groupBox_de_registros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_de_registros.Name = "groupBox_de_registros";
            groupBox_de_registros.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_de_registros.Size = new System.Drawing.Size(1082, 426);
            groupBox_de_registros.TabIndex = 13;
            groupBox_de_registros.TabStop = false;
            // 
            // Pedido_Articulos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1100, 444);
            Controls.Add(groupBox_de_registros);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Pedido_Articulos";
            Text = "Pedido_Articulos";
            ((System.ComponentModel.ISupportInitialize)tabla_de_pedidos).EndInit();
            groupBox_de_registros.ResumeLayout(false);
            groupBox_de_registros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campo_de_nombre;
        private System.Windows.Forms.TextBox campo_de_direccion;
        private System.Windows.Forms.TextBox campo_de_telefono;
        private System.Windows.Forms.ComboBox comboBox_de_sucursales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tabla_de_pedidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox_de_registros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_de_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_categoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Agregar;
    }
}
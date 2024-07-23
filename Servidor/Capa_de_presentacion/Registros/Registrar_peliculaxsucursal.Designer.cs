namespace Servidor
{
    partial class Registrar_peliculaxsucursal
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
            groupBox_de_registros_de_articulos = new GroupBox();
            tabla = new DataGridView();
            btn_restablecer_marcador = new Button();
            btn_corregir = new Button();
            btn_escoger_cantidad = new Button();
            campo_de_cantidad_de_inventario = new TextBox();
            label6 = new Label();
            campo_de_encargado = new TextBox();
            label5 = new Label();
            label4 = new Label();
            campo_de_direccion = new TextBox();
            campo_de_id_sucursal = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBox_de_sucursal = new ComboBox();
            label1 = new Label();
            btn_Guardar = new Button();
            id_de_pelicula = new DataGridViewTextBoxColumn();
            _titulo = new DataGridViewTextBoxColumn();
            Id_categoria = new DataGridViewTextBoxColumn();
            Nombre_categoria = new DataGridViewTextBoxColumn();
            anio_de_lanzamiento = new DataGridViewTextBoxColumn();
            idioma = new DataGridViewTextBoxColumn();
            Seleccionar = new DataGridViewCheckBoxColumn();
            groupBox_de_registros_de_articulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // groupBox_de_registros_de_articulos
            // 
            groupBox_de_registros_de_articulos.Controls.Add(tabla);
            groupBox_de_registros_de_articulos.Controls.Add(btn_restablecer_marcador);
            groupBox_de_registros_de_articulos.Controls.Add(btn_corregir);
            groupBox_de_registros_de_articulos.Controls.Add(btn_escoger_cantidad);
            groupBox_de_registros_de_articulos.Controls.Add(campo_de_cantidad_de_inventario);
            groupBox_de_registros_de_articulos.Controls.Add(label6);
            groupBox_de_registros_de_articulos.Controls.Add(campo_de_encargado);
            groupBox_de_registros_de_articulos.Controls.Add(label5);
            groupBox_de_registros_de_articulos.Controls.Add(label4);
            groupBox_de_registros_de_articulos.Controls.Add(campo_de_direccion);
            groupBox_de_registros_de_articulos.Controls.Add(campo_de_id_sucursal);
            groupBox_de_registros_de_articulos.Controls.Add(label3);
            groupBox_de_registros_de_articulos.Controls.Add(label2);
            groupBox_de_registros_de_articulos.Controls.Add(comboBox_de_sucursal);
            groupBox_de_registros_de_articulos.Controls.Add(label1);
            groupBox_de_registros_de_articulos.Controls.Add(btn_Guardar);
            groupBox_de_registros_de_articulos.Location = new Point(14, 38);
            groupBox_de_registros_de_articulos.Margin = new Padding(4, 3, 4, 3);
            groupBox_de_registros_de_articulos.Name = "groupBox_de_registros_de_articulos";
            groupBox_de_registros_de_articulos.Padding = new Padding(4, 3, 4, 3);
            groupBox_de_registros_de_articulos.Size = new Size(1247, 534);
            groupBox_de_registros_de_articulos.TabIndex = 16;
            groupBox_de_registros_de_articulos.TabStop = false;
            groupBox_de_registros_de_articulos.Text = "Películas por sucursal";
            // 
            // tabla
            // 
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { id_de_pelicula, _titulo, Id_categoria, Nombre_categoria, anio_de_lanzamiento, idioma, Seleccionar });
            tabla.Location = new Point(453, 78);
            tabla.Margin = new Padding(4, 3, 4, 3);
            tabla.Name = "tabla";
            tabla.Size = new Size(775, 260);
            tabla.TabIndex = 0;
            tabla.CellContentClick += tabla_CellContentClick;
            // 
            // btn_restablecer_marcador
            // 
            btn_restablecer_marcador.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_restablecer_marcador.ImageAlign = ContentAlignment.TopCenter;
            btn_restablecer_marcador.Location = new Point(892, 344);
            btn_restablecer_marcador.Margin = new Padding(4, 3, 4, 3);
            btn_restablecer_marcador.Name = "btn_restablecer_marcador";
            btn_restablecer_marcador.Size = new Size(133, 33);
            btn_restablecer_marcador.TabIndex = 23;
            btn_restablecer_marcador.Text = "Restablecer";
            btn_restablecer_marcador.UseVisualStyleBackColor = true;
            btn_restablecer_marcador.Click += btn_restablecer_marcador_Click;
            // 
            // btn_corregir
            // 
            btn_corregir.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_corregir.ImageAlign = ContentAlignment.TopCenter;
            btn_corregir.Location = new Point(828, 344);
            btn_corregir.Margin = new Padding(4, 3, 4, 3);
            btn_corregir.Name = "btn_corregir";
            btn_corregir.Size = new Size(57, 33);
            btn_corregir.TabIndex = 22;
            btn_corregir.Text = "-";
            btn_corregir.UseVisualStyleBackColor = true;
            btn_corregir.Click += btn_corregir_Click;
            // 
            // btn_escoger_cantidad
            // 
            btn_escoger_cantidad.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_escoger_cantidad.Location = new Point(765, 344);
            btn_escoger_cantidad.Margin = new Padding(4, 3, 4, 3);
            btn_escoger_cantidad.Name = "btn_escoger_cantidad";
            btn_escoger_cantidad.Size = new Size(56, 33);
            btn_escoger_cantidad.TabIndex = 21;
            btn_escoger_cantidad.Text = "+";
            btn_escoger_cantidad.UseVisualStyleBackColor = true;
            btn_escoger_cantidad.Click += btn_escoger_cantidad_Click;
            // 
            // campo_de_cantidad_de_inventario
            // 
            campo_de_cantidad_de_inventario.Location = new Point(662, 350);
            campo_de_cantidad_de_inventario.Margin = new Padding(4, 3, 4, 3);
            campo_de_cantidad_de_inventario.Name = "campo_de_cantidad_de_inventario";
            campo_de_cantidad_de_inventario.ReadOnly = true;
            campo_de_cantidad_de_inventario.Size = new Size(96, 23);
            campo_de_cantidad_de_inventario.TabIndex = 19;
            campo_de_cantidad_de_inventario.Text = "0";
            campo_de_cantidad_de_inventario.TextAlign = HorizontalAlignment.Center;
            campo_de_cantidad_de_inventario.TextChanged += campo_de_cantidad_de_inventario_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(455, 347);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(171, 20);
            label6.TabIndex = 20;
            label6.Text = "Cantidad de inventario:";
            // 
            // campo_de_encargado
            // 
            campo_de_encargado.Location = new Point(136, 294);
            campo_de_encargado.Margin = new Padding(4, 3, 4, 3);
            campo_de_encargado.Multiline = true;
            campo_de_encargado.Name = "campo_de_encargado";
            campo_de_encargado.ReadOnly = true;
            campo_de_encargado.Size = new Size(290, 28);
            campo_de_encargado.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 294);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 17;
            label5.Text = "Encargado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(453, 18);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 31);
            label4.TabIndex = 16;
            label4.Text = "Películas:";
            // 
            // campo_de_direccion
            // 
            campo_de_direccion.Location = new Point(122, 158);
            campo_de_direccion.Margin = new Padding(4, 3, 4, 3);
            campo_de_direccion.Multiline = true;
            campo_de_direccion.Name = "campo_de_direccion";
            campo_de_direccion.ReadOnly = true;
            campo_de_direccion.Size = new Size(290, 101);
            campo_de_direccion.TabIndex = 11;
            // 
            // campo_de_id_sucursal
            // 
            campo_de_id_sucursal.Location = new Point(254, 102);
            campo_de_id_sucursal.Margin = new Padding(4, 3, 4, 3);
            campo_de_id_sucursal.Name = "campo_de_id_sucursal";
            campo_de_id_sucursal.ReadOnly = true;
            campo_de_id_sucursal.Size = new Size(172, 23);
            campo_de_id_sucursal.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 99);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 10;
            label3.Text = "Identificación de sucursal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 156);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 9;
            label2.Text = "Dirección:";
            // 
            // comboBox_de_sucursal
            // 
            comboBox_de_sucursal.FormattingEnabled = true;
            comboBox_de_sucursal.Location = new Point(118, 39);
            comboBox_de_sucursal.Margin = new Padding(4, 3, 4, 3);
            comboBox_de_sucursal.Name = "comboBox_de_sucursal";
            comboBox_de_sucursal.Size = new Size(185, 23);
            comboBox_de_sucursal.TabIndex = 2;
            comboBox_de_sucursal.SelectedIndexChanged += comboBox_de_sucursal_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 7;
            label1.Text = "Sucursal:";
            // 
            // btn_Guardar
            // 
            btn_Guardar.Enabled = false;
            btn_Guardar.Location = new Point(106, 399);
            btn_Guardar.Margin = new Padding(4, 3, 4, 3);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(197, 45);
            btn_Guardar.TabIndex = 6;
            btn_Guardar.Text = "Guardar todo";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // id_de_pelicula
            // 
            id_de_pelicula.Frozen = true;
            id_de_pelicula.HeaderText = "Id Película";
            id_de_pelicula.Name = "id_de_pelicula";
            id_de_pelicula.ReadOnly = true;
            id_de_pelicula.Width = 140;
            // 
            // _titulo
            // 
            _titulo.Frozen = true;
            _titulo.HeaderText = "Título";
            _titulo.Name = "_titulo";
            _titulo.ReadOnly = true;
            _titulo.Width = 140;
            // 
            // Id_categoria
            // 
            Id_categoria.Frozen = true;
            Id_categoria.HeaderText = "Id Categoria";
            Id_categoria.Name = "Id_categoria";
            Id_categoria.ReadOnly = true;
            // 
            // Nombre_categoria
            // 
            Nombre_categoria.Frozen = true;
            Nombre_categoria.HeaderText = "Nombre categoría";
            Nombre_categoria.Name = "Nombre_categoria";
            Nombre_categoria.ReadOnly = true;
            Nombre_categoria.Width = 140;
            // 
            // anio_de_lanzamiento
            // 
            anio_de_lanzamiento.HeaderText = "Año de lanzamiento";
            anio_de_lanzamiento.Name = "anio_de_lanzamiento";
            anio_de_lanzamiento.ReadOnly = true;
            // 
            // idioma
            // 
            idioma.HeaderText = "Idioma";
            idioma.Name = "idioma";
            idioma.ReadOnly = true;
            // 
            // Seleccionar
            // 
            Seleccionar.HeaderText = "Agregar";
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Resizable = DataGridViewTriState.True;
            Seleccionar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Registrar_peliculaxsucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 655);
            Controls.Add(groupBox_de_registros_de_articulos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registrar_peliculaxsucursal";
            Text = "Registrar_peliculaxsucursal";
            groupBox_de_registros_de_articulos.ResumeLayout(false);
            groupBox_de_registros_de_articulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_de_registros_de_articulos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.TextBox campo_de_direccion;
        private System.Windows.Forms.TextBox campo_de_id_sucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_de_sucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox campo_de_encargado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_escoger_cantidad;
        private System.Windows.Forms.TextBox campo_de_cantidad_de_inventario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_corregir;
        private System.Windows.Forms.Button btn_restablecer_marcador;
        private DataGridViewTextBoxColumn id_de_pelicula;
        private DataGridViewTextBoxColumn _titulo;
        private DataGridViewTextBoxColumn Id_categoria;
        private DataGridViewTextBoxColumn Nombre_categoria;
        private DataGridViewTextBoxColumn anio_de_lanzamiento;
        private DataGridViewTextBoxColumn idioma;
        private DataGridViewCheckBoxColumn Seleccionar;
    }
}
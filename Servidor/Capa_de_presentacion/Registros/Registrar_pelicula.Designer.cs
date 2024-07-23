namespace Servidor
{
    partial class Registrar_pelicula
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
            mensaje = new Label();
            boton_para_continuar_registro = new Button();
            label5 = new Label();
            campo_de_ID = new TextBox();
            group_de_registros_pelicula = new GroupBox();
            label8 = new Label();
            campo_descripcion_categoria = new TextBox();
            label7 = new Label();
            label6 = new Label();
            Nombre_de_categoria = new TextBox();
            comboBox_de_idioma = new ComboBox();
            comboBox_de_ano = new ComboBox();
            comboBox_de_categoria = new ComboBox();
            boton_de_guardar = new Button();
            boton_de_cancelar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            campo_titulo = new TextBox();
            group_de_registros_pelicula.SuspendLayout();
            SuspendLayout();
            // 
            // mensaje
            // 
            mensaje.AutoSize = true;
            mensaje.ForeColor = Color.Red;
            mensaje.Location = new Point(345, 70);
            mensaje.Margin = new Padding(4, 0, 4, 0);
            mensaje.Name = "mensaje";
            mensaje.Size = new Size(215, 15);
            mensaje.TabIndex = 22;
            mensaje.Text = "*El número que registro contiene letras.";
            mensaje.Visible = false;
            // 
            // boton_para_continuar_registro
            // 
            boton_para_continuar_registro.Location = new Point(322, 105);
            boton_para_continuar_registro.Margin = new Padding(4, 3, 4, 3);
            boton_para_continuar_registro.Name = "boton_para_continuar_registro";
            boton_para_continuar_registro.Size = new Size(274, 50);
            boton_para_continuar_registro.TabIndex = 18;
            boton_para_continuar_registro.Text = "Guardar y continuar";
            boton_para_continuar_registro.UseVisualStyleBackColor = true;
            boton_para_continuar_registro.Click += boton_para_continuar_registro_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 31);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 21;
            label5.Text = "Identificación de película:";
            // 
            // campo_de_ID
            // 
            campo_de_ID.Location = new Point(433, 28);
            campo_de_ID.Margin = new Padding(4, 3, 4, 3);
            campo_de_ID.Name = "campo_de_ID";
            campo_de_ID.Size = new Size(206, 23);
            campo_de_ID.TabIndex = 20;
            campo_de_ID.TextChanged += campo_de_ID_TextChanged;
            // 
            // group_de_registros_pelicula
            // 
            group_de_registros_pelicula.Controls.Add(label8);
            group_de_registros_pelicula.Controls.Add(campo_descripcion_categoria);
            group_de_registros_pelicula.Controls.Add(label7);
            group_de_registros_pelicula.Controls.Add(label6);
            group_de_registros_pelicula.Controls.Add(Nombre_de_categoria);
            group_de_registros_pelicula.Controls.Add(comboBox_de_idioma);
            group_de_registros_pelicula.Controls.Add(comboBox_de_ano);
            group_de_registros_pelicula.Controls.Add(comboBox_de_categoria);
            group_de_registros_pelicula.Controls.Add(boton_de_guardar);
            group_de_registros_pelicula.Controls.Add(boton_de_cancelar);
            group_de_registros_pelicula.Controls.Add(label4);
            group_de_registros_pelicula.Controls.Add(label3);
            group_de_registros_pelicula.Controls.Add(label2);
            group_de_registros_pelicula.Controls.Add(label1);
            group_de_registros_pelicula.Controls.Add(campo_titulo);
            group_de_registros_pelicula.Enabled = false;
            group_de_registros_pelicula.Location = new Point(13, 162);
            group_de_registros_pelicula.Margin = new Padding(4, 3, 4, 3);
            group_de_registros_pelicula.Name = "group_de_registros_pelicula";
            group_de_registros_pelicula.Padding = new Padding(4, 3, 4, 3);
            group_de_registros_pelicula.Size = new Size(909, 344);
            group_de_registros_pelicula.TabIndex = 17;
            group_de_registros_pelicula.TabStop = false;
            group_de_registros_pelicula.Text = "Registro de datos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(503, 114);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 20;
            label8.Text = "Descripción:";
            // 
            // campo_descripcion_categoria
            // 
            campo_descripcion_categoria.Location = new Point(581, 111);
            campo_descripcion_categoria.Margin = new Padding(4, 3, 4, 3);
            campo_descripcion_categoria.Name = "campo_descripcion_categoria";
            campo_descripcion_categoria.ReadOnly = true;
            campo_descripcion_categoria.Size = new Size(201, 23);
            campo_descripcion_categoria.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(543, 45);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 18;
            label7.Text = "Datos de categoría:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(503, 85);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 17;
            label6.Text = "Nombre:";
            // 
            // Nombre_de_categoria
            // 
            Nombre_de_categoria.Location = new Point(581, 82);
            Nombre_de_categoria.Margin = new Padding(4, 3, 4, 3);
            Nombre_de_categoria.Name = "Nombre_de_categoria";
            Nombre_de_categoria.ReadOnly = true;
            Nombre_de_categoria.Size = new Size(201, 23);
            Nombre_de_categoria.TabIndex = 16;
            // 
            // comboBox_de_idioma
            // 
            comboBox_de_idioma.FormattingEnabled = true;
            comboBox_de_idioma.Items.AddRange(new object[] { "Inglés", "Español", "Chino mandarin", "Coreano", "Francés", "Italiano", "Aléman", "Ruso", "Filipino", "Japonés", "Esparanto ", "Griego", "Rumano", "Árabe", "Hebreo", "Georgiano" });
            comboBox_de_idioma.Location = new Point(119, 186);
            comboBox_de_idioma.Margin = new Padding(4, 3, 4, 3);
            comboBox_de_idioma.Name = "comboBox_de_idioma";
            comboBox_de_idioma.Size = new Size(156, 23);
            comboBox_de_idioma.TabIndex = 15;
            // 
            // comboBox_de_ano
            // 
            comboBox_de_ano.FormattingEnabled = true;
            comboBox_de_ano.Items.AddRange(new object[] { "1900  ", "1901  ", "1902  ", "1903  ", "1904  ", "1905  ", "1906  ", "1907  ", "1908  ", "1909  ", "1910  ", "1911  ", "1912  ", "1913  ", "1914  ", "1915  ", "1916  ", "1917  ", "1918  ", "1919  ", "1920  ", "1921  ", "1922  ", "1923  ", "1924  ", "1925  ", "1926  ", "1927  ", "1928  ", "1929  ", "1930  ", "1931  ", "1932  ", "1933  ", "1934  ", "1935  ", "1936  ", "1937  ", "1938  ", "1939  ", "1940  ", "1941  ", "1942  ", "1943  ", "1944  ", "1945  ", "1946  ", "1947  ", "1948  ", "1949  ", "1950  ", "1951  ", "1952  ", "1953  ", "1954  ", "1955  ", "1956  ", "1957  ", "1958  ", "1959  ", "1960  ", "1961  ", "1962  ", "1963  ", "1964  ", "1965  ", "1966  ", "1967  ", "1968  ", "1969  ", "1970  ", "1971  ", "1972  ", "1973  ", "1974  ", "1975  ", "1976  ", "1977  ", "1978  ", "1979  ", "1980  ", "1981  ", "1982  ", "1983  ", "1984  ", "1985  ", "1986  ", "1987  ", "1988  ", "1989  ", "1990  ", "1991  ", "1992  ", "1993  ", "1994  ", "1995  ", "1996  ", "1997  ", "1998  ", "1999  ", "2000  ", "2001  ", "2002  ", "2003  ", "2004  ", "2005  ", "2006  ", "2007  ", "2008  ", "2009  ", "2010  ", "2011  ", "2012  ", "2013  ", "2014  ", "2015  ", "2016  ", "2017  ", "2018  ", "2019  ", "2020  ", "2021  ", "2022  ", "2023  ", "2024" });
            comboBox_de_ano.Location = new Point(134, 141);
            comboBox_de_ano.Margin = new Padding(4, 3, 4, 3);
            comboBox_de_ano.Name = "comboBox_de_ano";
            comboBox_de_ano.Size = new Size(156, 23);
            comboBox_de_ano.TabIndex = 14;
            // 
            // comboBox_de_categoria
            // 
            comboBox_de_categoria.FormattingEnabled = true;
            comboBox_de_categoria.Location = new Point(119, 90);
            comboBox_de_categoria.Margin = new Padding(4, 3, 4, 3);
            comboBox_de_categoria.Name = "comboBox_de_categoria";
            comboBox_de_categoria.Size = new Size(201, 23);
            comboBox_de_categoria.TabIndex = 13;
            comboBox_de_categoria.SelectedIndexChanged += comboBox_de_categoria_SelectedIndexChanged;
            // 
            // boton_de_guardar
            // 
            boton_de_guardar.Location = new Point(682, 277);
            boton_de_guardar.Margin = new Padding(4, 3, 4, 3);
            boton_de_guardar.Name = "boton_de_guardar";
            boton_de_guardar.Size = new Size(219, 50);
            boton_de_guardar.TabIndex = 11;
            boton_de_guardar.Text = "Guardar";
            boton_de_guardar.UseVisualStyleBackColor = true;
            boton_de_guardar.Click += boton_de_guardar_Click;
            // 
            // boton_de_cancelar
            // 
            boton_de_cancelar.Location = new Point(10, 277);
            boton_de_cancelar.Margin = new Padding(4, 3, 4, 3);
            boton_de_cancelar.Name = "boton_de_cancelar";
            boton_de_cancelar.Size = new Size(219, 50);
            boton_de_cancelar.TabIndex = 10;
            boton_de_cancelar.Text = "Cancelar";
            boton_de_cancelar.UseVisualStyleBackColor = true;
            boton_de_cancelar.Click += boton_de_cancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 195);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "Idioma:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 144);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 5;
            label3.Text = "Año de lanzamiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Categoría:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Título:";
            // 
            // campo_titulo
            // 
            campo_titulo.Location = new Point(119, 37);
            campo_titulo.Margin = new Padding(4, 3, 4, 3);
            campo_titulo.MaxLength = 100;
            campo_titulo.Name = "campo_titulo";
            campo_titulo.Size = new Size(201, 23);
            campo_titulo.TabIndex = 0;
            // 
            // Registrar_pelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(mensaje);
            Controls.Add(boton_para_continuar_registro);
            Controls.Add(label5);
            Controls.Add(campo_de_ID);
            Controls.Add(group_de_registros_pelicula);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registrar_pelicula";
            Text = "Registrar_pelicula";
            group_de_registros_pelicula.ResumeLayout(false);
            group_de_registros_pelicula.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.Button boton_para_continuar_registro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campo_de_ID;
        private System.Windows.Forms.GroupBox group_de_registros_pelicula;
        private System.Windows.Forms.ComboBox comboBox_de_categoria;
        private System.Windows.Forms.Button boton_de_guardar;
        private System.Windows.Forms.Button boton_de_cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campo_titulo;
        private System.Windows.Forms.ComboBox comboBox_de_idioma;
        private System.Windows.Forms.ComboBox comboBox_de_ano;
        private Label label8;
        private TextBox campo_descripcion_categoria;
        private Label label7;
        private Label label6;
        private TextBox Nombre_de_categoria;
    }
}
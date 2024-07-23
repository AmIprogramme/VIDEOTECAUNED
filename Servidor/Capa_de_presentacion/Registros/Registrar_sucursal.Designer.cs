namespace Servidor
{
    partial class Registrar_sucursal
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
            boton_de_registro_id = new Button();
            label4 = new Label();
            campo_para_id = new TextBox();
            group_para_registro_de_datos = new GroupBox();
            label6 = new Label();
            txt_nombre_completo_encargado = new TextBox();
            groupBox1 = new GroupBox();
            radioButton_activo = new RadioButton();
            radioButton_inactivo = new RadioButton();
            campo_telefono = new TextBox();
            label2 = new Label();
            campo_de_direccion = new TextBox();
            comboBox_de_encargado = new ComboBox();
            label5 = new Label();
            btn_guardar = new Button();
            btn_cancelar = new Button();
            label3 = new Label();
            label1 = new Label();
            campo_de_nombre = new TextBox();
            group_para_registro_de_datos.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mensaje
            // 
            mensaje.AutoSize = true;
            mensaje.ForeColor = Color.Red;
            mensaje.Location = new Point(359, 81);
            mensaje.Margin = new Padding(4, 0, 4, 0);
            mensaje.Name = "mensaje";
            mensaje.Size = new Size(250, 15);
            mensaje.TabIndex = 19;
            mensaje.Text = "*Solo se aceptan número para poder registrar*";
            mensaje.Visible = false;
            // 
            // boton_de_registro_id
            // 
            boton_de_registro_id.Location = new Point(330, 121);
            boton_de_registro_id.Margin = new Padding(4, 3, 4, 3);
            boton_de_registro_id.Name = "boton_de_registro_id";
            boton_de_registro_id.Size = new Size(260, 35);
            boton_de_registro_id.TabIndex = 15;
            boton_de_registro_id.Text = "Registrar Id y continuar";
            boton_de_registro_id.UseVisualStyleBackColor = true;
            boton_de_registro_id.Click += boton_de_registro_id_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 36);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 15);
            label4.TabIndex = 18;
            label4.Text = "Identificación de sucursal:";
            // 
            // campo_para_id
            // 
            campo_para_id.Location = new Point(406, 32);
            campo_para_id.Margin = new Padding(4, 3, 4, 3);
            campo_para_id.Name = "campo_para_id";
            campo_para_id.Size = new Size(238, 23);
            campo_para_id.TabIndex = 17;
            campo_para_id.TextChanged += campo_para_id_TextChanged;
            // 
            // group_para_registro_de_datos
            // 
            group_para_registro_de_datos.Controls.Add(label6);
            group_para_registro_de_datos.Controls.Add(txt_nombre_completo_encargado);
            group_para_registro_de_datos.Controls.Add(groupBox1);
            group_para_registro_de_datos.Controls.Add(campo_telefono);
            group_para_registro_de_datos.Controls.Add(label2);
            group_para_registro_de_datos.Controls.Add(campo_de_direccion);
            group_para_registro_de_datos.Controls.Add(comboBox_de_encargado);
            group_para_registro_de_datos.Controls.Add(label5);
            group_para_registro_de_datos.Controls.Add(btn_guardar);
            group_para_registro_de_datos.Controls.Add(btn_cancelar);
            group_para_registro_de_datos.Controls.Add(label3);
            group_para_registro_de_datos.Controls.Add(label1);
            group_para_registro_de_datos.Controls.Add(campo_de_nombre);
            group_para_registro_de_datos.Enabled = false;
            group_para_registro_de_datos.Location = new Point(20, 163);
            group_para_registro_de_datos.Margin = new Padding(4, 3, 4, 3);
            group_para_registro_de_datos.Name = "group_para_registro_de_datos";
            group_para_registro_de_datos.Padding = new Padding(4, 3, 4, 3);
            group_para_registro_de_datos.Size = new Size(899, 343);
            group_para_registro_de_datos.TabIndex = 14;
            group_para_registro_de_datos.TabStop = false;
            group_para_registro_de_datos.Text = "Datos a llenar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(636, 19);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(186, 15);
            label6.TabIndex = 20;
            label6.Text = "Nombre completo del encargado:";
            // 
            // txt_nombre_completo_encargado
            // 
            txt_nombre_completo_encargado.Location = new Point(616, 37);
            txt_nombre_completo_encargado.Margin = new Padding(4, 3, 4, 3);
            txt_nombre_completo_encargado.Name = "txt_nombre_completo_encargado";
            txt_nombre_completo_encargado.ReadOnly = true;
            txt_nombre_completo_encargado.Size = new Size(238, 23);
            txt_nombre_completo_encargado.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton_activo);
            groupBox1.Controls.Add(radioButton_inactivo);
            groupBox1.Location = new Point(419, 81);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(178, 54);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado";
            // 
            // radioButton_activo
            // 
            radioButton_activo.AutoSize = true;
            radioButton_activo.Location = new Point(15, 22);
            radioButton_activo.Margin = new Padding(4, 3, 4, 3);
            radioButton_activo.Name = "radioButton_activo";
            radioButton_activo.Size = new Size(59, 19);
            radioButton_activo.TabIndex = 16;
            radioButton_activo.Text = "Activo";
            radioButton_activo.UseVisualStyleBackColor = true;
            // 
            // radioButton_inactivo
            // 
            radioButton_inactivo.AutoSize = true;
            radioButton_inactivo.Checked = true;
            radioButton_inactivo.Location = new Point(98, 22);
            radioButton_inactivo.Margin = new Padding(4, 3, 4, 3);
            radioButton_inactivo.Name = "radioButton_inactivo";
            radioButton_inactivo.Size = new Size(67, 19);
            radioButton_inactivo.TabIndex = 17;
            radioButton_inactivo.TabStop = true;
            radioButton_inactivo.Text = "Inactivo";
            radioButton_inactivo.UseVisualStyleBackColor = true;
            // 
            // campo_telefono
            // 
            campo_telefono.Location = new Point(92, 165);
            campo_telefono.Margin = new Padding(4, 3, 4, 3);
            campo_telefono.Name = "campo_telefono";
            campo_telefono.Size = new Size(238, 23);
            campo_telefono.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 13;
            label2.Text = "Dirección:";
            // 
            // campo_de_direccion
            // 
            campo_de_direccion.Location = new Point(92, 77);
            campo_de_direccion.Margin = new Padding(4, 3, 4, 3);
            campo_de_direccion.Multiline = true;
            campo_de_direccion.Name = "campo_de_direccion";
            campo_de_direccion.Size = new Size(238, 61);
            campo_de_direccion.TabIndex = 12;
            // 
            // comboBox_de_encargado
            // 
            comboBox_de_encargado.FormattingEnabled = true;
            comboBox_de_encargado.Location = new Point(499, 36);
            comboBox_de_encargado.Margin = new Padding(4, 3, 4, 3);
            comboBox_de_encargado.Name = "comboBox_de_encargado";
            comboBox_de_encargado.Size = new Size(90, 23);
            comboBox_de_encargado.TabIndex = 11;
            comboBox_de_encargado.SelectedIndexChanged += comboBox_de_encargado_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(419, 39);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 10;
            label5.Text = "Encargado:";
            // 
            // btn_guardar
            // 
            btn_guardar.Enabled = false;
            btn_guardar.Location = new Point(706, 276);
            btn_guardar.Margin = new Padding(4, 3, 4, 3);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(187, 59);
            btn_guardar.TabIndex = 8;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(8, 276);
            btn_cancelar.Margin = new Padding(4, 3, 4, 3);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(187, 59);
            btn_cancelar.TabIndex = 7;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 165);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Teléfono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // campo_de_nombre
            // 
            campo_de_nombre.Location = new Point(92, 35);
            campo_de_nombre.Margin = new Padding(4, 3, 4, 3);
            campo_de_nombre.Name = "campo_de_nombre";
            campo_de_nombre.Size = new Size(238, 23);
            campo_de_nombre.TabIndex = 0;
            // 
            // Registrar_sucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(mensaje);
            Controls.Add(boton_de_registro_id);
            Controls.Add(label4);
            Controls.Add(campo_para_id);
            Controls.Add(group_para_registro_de_datos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registrar_sucursal";
            Text = "Registrar_sucursal";
            group_para_registro_de_datos.ResumeLayout(false);
            group_para_registro_de_datos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.Button boton_de_registro_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campo_para_id;
        private System.Windows.Forms.GroupBox group_para_registro_de_datos;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campo_de_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campo_de_direccion;
        private System.Windows.Forms.ComboBox comboBox_de_encargado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_activo;
        private System.Windows.Forms.RadioButton radioButton_inactivo;
        private System.Windows.Forms.TextBox campo_telefono;
        private Label label6;
        private TextBox txt_nombre_completo_encargado;
    }
}
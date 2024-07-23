namespace Servidor
{
    partial class Registrar_cliente
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
            btn_registrar_id = new Button();
            campo_para_id = new TextBox();
            label5 = new Label();
            group_de_registro_de_cliente = new GroupBox();
            comboBox_de_identificaciones = new ComboBox();
            campo_de_nacimiento = new TextBox();
            panel_fecha_de_ingreso = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            btn_guardar = new Button();
            btn_cancelar = new Button();
            label4 = new Label();
            campo_para_segundo_apellido = new TextBox();
            label3 = new Label();
            campo_para_primer_apellido = new TextBox();
            label2 = new Label();
            campo_de_nombre = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton_activo = new RadioButton();
            radioButton_inactivo = new RadioButton();
            group_de_registro_de_cliente.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // mensaje
            // 
            mensaje.AutoSize = true;
            mensaje.ForeColor = Color.Red;
            mensaje.Location = new Point(317, 75);
            mensaje.Margin = new Padding(4, 0, 4, 0);
            mensaje.Name = "mensaje";
            mensaje.Size = new Size(257, 15);
            mensaje.TabIndex = 29;
            mensaje.Text = "*Solo se aceptan número para la identificación*";
            mensaje.Visible = false;
            // 
            // btn_registrar_id
            // 
            btn_registrar_id.Location = new Point(594, 20);
            btn_registrar_id.Margin = new Padding(4, 3, 4, 3);
            btn_registrar_id.Name = "btn_registrar_id";
            btn_registrar_id.Size = new Size(251, 35);
            btn_registrar_id.TabIndex = 26;
            btn_registrar_id.Text = "Registrar y continuar";
            btn_registrar_id.UseVisualStyleBackColor = true;
            btn_registrar_id.Click += btn_registrar_id_Click;
            // 
            // campo_para_id
            // 
            campo_para_id.Location = new Point(364, 27);
            campo_para_id.Margin = new Padding(4, 3, 4, 3);
            campo_para_id.Name = "campo_para_id";
            campo_para_id.Size = new Size(201, 23);
            campo_para_id.TabIndex = 28;
            campo_para_id.TextChanged += campo_para_id_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 30);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 27;
            label5.Text = "Identificación del cliente:";
            // 
            // group_de_registro_de_cliente
            // 
            group_de_registro_de_cliente.Controls.Add(groupBox1);
            group_de_registro_de_cliente.Controls.Add(comboBox_de_identificaciones);
            group_de_registro_de_cliente.Controls.Add(campo_de_nacimiento);
            group_de_registro_de_cliente.Controls.Add(panel_fecha_de_ingreso);
            group_de_registro_de_cliente.Controls.Add(label7);
            group_de_registro_de_cliente.Controls.Add(label6);
            group_de_registro_de_cliente.Controls.Add(btn_guardar);
            group_de_registro_de_cliente.Controls.Add(btn_cancelar);
            group_de_registro_de_cliente.Controls.Add(label4);
            group_de_registro_de_cliente.Controls.Add(campo_para_segundo_apellido);
            group_de_registro_de_cliente.Controls.Add(label3);
            group_de_registro_de_cliente.Controls.Add(campo_para_primer_apellido);
            group_de_registro_de_cliente.Controls.Add(label2);
            group_de_registro_de_cliente.Controls.Add(campo_de_nombre);
            group_de_registro_de_cliente.Controls.Add(label1);
            group_de_registro_de_cliente.Enabled = false;
            group_de_registro_de_cliente.Location = new Point(13, 140);
            group_de_registro_de_cliente.Margin = new Padding(4, 3, 4, 3);
            group_de_registro_de_cliente.Name = "group_de_registro_de_cliente";
            group_de_registro_de_cliente.Padding = new Padding(4, 3, 4, 3);
            group_de_registro_de_cliente.Size = new Size(911, 358);
            group_de_registro_de_cliente.TabIndex = 30;
            group_de_registro_de_cliente.TabStop = false;
            group_de_registro_de_cliente.Text = "Registro de encargado";
            // 
            // comboBox_de_identificaciones
            // 
            comboBox_de_identificaciones.FormattingEnabled = true;
            comboBox_de_identificaciones.Location = new Point(116, 48);
            comboBox_de_identificaciones.Name = "comboBox_de_identificaciones";
            comboBox_de_identificaciones.Size = new Size(133, 23);
            comboBox_de_identificaciones.TabIndex = 31;
            comboBox_de_identificaciones.SelectedIndexChanged += comboBox_de_identificaciones_SelectedIndexChanged;
            // 
            // campo_de_nacimiento
            // 
            campo_de_nacimiento.Location = new Point(155, 270);
            campo_de_nacimiento.Margin = new Padding(4, 3, 4, 3);
            campo_de_nacimiento.Name = "campo_de_nacimiento";
            campo_de_nacimiento.ReadOnly = true;
            campo_de_nacimiento.Size = new Size(187, 23);
            campo_de_nacimiento.TabIndex = 30;
            // 
            // panel_fecha_de_ingreso
            // 
            panel_fecha_de_ingreso.Location = new Point(481, 45);
            panel_fecha_de_ingreso.Margin = new Padding(4, 3, 4, 3);
            panel_fecha_de_ingreso.Name = "panel_fecha_de_ingreso";
            panel_fecha_de_ingreso.Size = new Size(215, 23);
            panel_fecha_de_ingreso.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(375, 50);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 27;
            label7.Text = "Fecha de ingreso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 51);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 25;
            label6.Text = "Identificación:";
            // 
            // btn_guardar
            // 
            btn_guardar.Enabled = false;
            btn_guardar.Location = new Point(672, 285);
            btn_guardar.Margin = new Padding(4, 3, 4, 3);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(209, 59);
            btn_guardar.TabIndex = 13;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click_1;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(390, 285);
            btn_cancelar.Margin = new Padding(4, 3, 4, 3);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(209, 59);
            btn_cancelar.TabIndex = 12;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 270);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de nacimiento:";
            // 
            // campo_para_segundo_apellido
            // 
            campo_para_segundo_apellido.Location = new Point(141, 226);
            campo_para_segundo_apellido.Margin = new Padding(4, 3, 4, 3);
            campo_para_segundo_apellido.Name = "campo_para_segundo_apellido";
            campo_para_segundo_apellido.ReadOnly = true;
            campo_para_segundo_apellido.Size = new Size(201, 23);
            campo_para_segundo_apellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 230);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Segundo apellido:";
            // 
            // campo_para_primer_apellido
            // 
            campo_para_primer_apellido.Location = new Point(125, 183);
            campo_para_primer_apellido.Margin = new Padding(4, 3, 4, 3);
            campo_para_primer_apellido.Name = "campo_para_primer_apellido";
            campo_para_primer_apellido.ReadOnly = true;
            campo_para_primer_apellido.Size = new Size(201, 23);
            campo_para_primer_apellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 183);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Primer apellido:";
            // 
            // campo_de_nombre
            // 
            campo_de_nombre.Location = new Point(89, 127);
            campo_de_nombre.Margin = new Padding(4, 3, 4, 3);
            campo_de_nombre.Name = "campo_de_nombre";
            campo_de_nombre.ReadOnly = true;
            campo_de_nombre.Size = new Size(201, 23);
            campo_de_nombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 127);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton_activo);
            groupBox1.Controls.Add(radioButton_inactivo);
            groupBox1.Location = new Point(375, 88);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(178, 54);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estado";
            // 
            // radioButton_activo
            // 
            radioButton_activo.AutoSize = true;
            radioButton_activo.Location = new Point(16, 22);
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
            radioButton_inactivo.Location = new Point(99, 22);
            radioButton_inactivo.Margin = new Padding(4, 3, 4, 3);
            radioButton_inactivo.Name = "radioButton_inactivo";
            radioButton_inactivo.Size = new Size(67, 19);
            radioButton_inactivo.TabIndex = 17;
            radioButton_inactivo.TabStop = true;
            radioButton_inactivo.Text = "Inactivo";
            radioButton_inactivo.UseVisualStyleBackColor = true;
            // 
            // Registrar_cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(group_de_registro_de_cliente);
            Controls.Add(mensaje);
            Controls.Add(btn_registrar_id);
            Controls.Add(campo_para_id);
            Controls.Add(label5);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registrar_cliente";
            Text = "Registrar_cliente";
            group_de_registro_de_cliente.ResumeLayout(false);
            group_de_registro_de_cliente.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.Button btn_registrar_id;
        private System.Windows.Forms.TextBox campo_para_id;
        private System.Windows.Forms.Label label5;
        private GroupBox group_de_registro_de_cliente;
        private ComboBox comboBox_de_identificaciones;
        private TextBox campo_de_nacimiento;
        private DateTimePicker panel_fecha_de_ingreso;
        private Label label7;
        private Label label6;
        private Button btn_guardar;
        private Button btn_cancelar;
        private Label label4;
        private TextBox campo_para_segundo_apellido;
        private Label label3;
        private TextBox campo_para_primer_apellido;
        private Label label2;
        private TextBox campo_de_nombre;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButton_activo;
        private RadioButton radioButton_inactivo;
    }
}
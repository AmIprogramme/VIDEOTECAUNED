namespace Servidor
{
    partial class Registrar_persona
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
            panel_fecha_de_nacimiento = new DateTimePicker();
            btn_guardar = new Button();
            btn_cancelar = new Button();
            label4 = new Label();
            campo_para_segundo_apellido = new TextBox();
            label3 = new Label();
            campo_para_primer_apellido = new TextBox();
            label2 = new Label();
            campo_de_nombre = new TextBox();
            label1 = new Label();
            group_de_registro_de_cliente.SuspendLayout();
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
            campo_para_id.MaxLength = 12;
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
            label5.Size = new Size(143, 15);
            label5.TabIndex = 27;
            label5.Text = "Identificación de persona:";
            // 
            // group_de_registro_de_cliente
            // 
            group_de_registro_de_cliente.Controls.Add(panel_fecha_de_nacimiento);
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
            group_de_registro_de_cliente.Location = new Point(12, 143);
            group_de_registro_de_cliente.Margin = new Padding(4, 3, 4, 3);
            group_de_registro_de_cliente.Name = "group_de_registro_de_cliente";
            group_de_registro_de_cliente.Padding = new Padding(4, 3, 4, 3);
            group_de_registro_de_cliente.Size = new Size(911, 358);
            group_de_registro_de_cliente.TabIndex = 25;
            group_de_registro_de_cliente.TabStop = false;
            group_de_registro_de_cliente.Text = "Registro de persona";
            // 
            // panel_fecha_de_nacimiento
            // 
            panel_fecha_de_nacimiento.Location = new Point(480, 37);
            panel_fecha_de_nacimiento.Margin = new Padding(4, 3, 4, 3);
            panel_fecha_de_nacimiento.Name = "panel_fecha_de_nacimiento";
            panel_fecha_de_nacimiento.Size = new Size(215, 23);
            panel_fecha_de_nacimiento.TabIndex = 14;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(672, 285);
            btn_guardar.Margin = new Padding(4, 3, 4, 3);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(209, 59);
            btn_guardar.TabIndex = 13;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
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
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 37);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de nacimiento:";
            // 
            // campo_para_segundo_apellido
            // 
            campo_para_segundo_apellido.Location = new Point(132, 136);
            campo_para_segundo_apellido.Margin = new Padding(4, 3, 4, 3);
            campo_para_segundo_apellido.MaxLength = 25;
            campo_para_segundo_apellido.Name = "campo_para_segundo_apellido";
            campo_para_segundo_apellido.Size = new Size(201, 23);
            campo_para_segundo_apellido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 140);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Segundo apellido:";
            // 
            // campo_para_primer_apellido
            // 
            campo_para_primer_apellido.Location = new Point(116, 93);
            campo_para_primer_apellido.Margin = new Padding(4, 3, 4, 3);
            campo_para_primer_apellido.MaxLength = 25;
            campo_para_primer_apellido.Name = "campo_para_primer_apellido";
            campo_para_primer_apellido.Size = new Size(201, 23);
            campo_para_primer_apellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Primer apellido:";
            // 
            // campo_de_nombre
            // 
            campo_de_nombre.Location = new Point(80, 37);
            campo_de_nombre.Margin = new Padding(4, 3, 4, 3);
            campo_de_nombre.MaxLength = 25;
            campo_de_nombre.Name = "campo_de_nombre";
            campo_de_nombre.Size = new Size(201, 23);
            campo_de_nombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // Registrar_persona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(mensaje);
            Controls.Add(btn_registrar_id);
            Controls.Add(campo_para_id);
            Controls.Add(label5);
            Controls.Add(group_de_registro_de_cliente);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registrar_persona";
            Text = "Registrar_persona";
            group_de_registro_de_cliente.ResumeLayout(false);
            group_de_registro_de_cliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.Button btn_registrar_id;
        private System.Windows.Forms.TextBox campo_para_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox group_de_registro_de_cliente;
        private System.Windows.Forms.DateTimePicker panel_fecha_de_nacimiento;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campo_para_segundo_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campo_para_primer_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campo_de_nombre;
        private System.Windows.Forms.Label label1;
    }
}
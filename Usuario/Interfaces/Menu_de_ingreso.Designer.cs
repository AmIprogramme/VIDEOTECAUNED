namespace Usuario.Interfaces
{
    partial class Menu_de_ingreso
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
            Campo_de_id_ingreso = new System.Windows.Forms.TextBox();
            btn_de_ingresar = new System.Windows.Forms.Button();
            Label_de_mensaje = new System.Windows.Forms.Label();
            Mensaje_de_conexion = new System.Windows.Forms.Label();
            btn_Historial = new System.Windows.Forms.Button();
            btn_hacer_reservacion = new System.Windows.Forms.Button();
            groupBox_de_botones = new System.Windows.Forms.GroupBox();
            btn_cambiar_usuario = new System.Windows.Forms.Button();
            groupBox_datos_de_usuario = new System.Windows.Forms.GroupBox();
            campo_p_apellido = new System.Windows.Forms.TextBox();
            campo_s_apellido = new System.Windows.Forms.TextBox();
            campo_nombre = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btn_encender = new System.Windows.Forms.Button();
            btn_apagar = new System.Windows.Forms.Button();
            groupBox_de_botones.SuspendLayout();
            groupBox_datos_de_usuario.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(14, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(427, 31);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos a VIDEOTECAUNED";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(176, 120);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(331, 24);
            label2.TabIndex = 1;
            label2.Text = "Digite su identificación de usuario aquí";
            // 
            // Campo_de_id_ingreso
            // 
            Campo_de_id_ingreso.Enabled = false;
            Campo_de_id_ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Campo_de_id_ingreso.Location = new System.Drawing.Point(164, 167);
            Campo_de_id_ingreso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Campo_de_id_ingreso.Name = "Campo_de_id_ingreso";
            Campo_de_id_ingreso.Size = new System.Drawing.Size(296, 26);
            Campo_de_id_ingreso.TabIndex = 2;
            Campo_de_id_ingreso.TextChanged += Campo_de_id_ingreso_TextChanged;
            // 
            // btn_de_ingresar
            // 
            btn_de_ingresar.Enabled = false;
            btn_de_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_de_ingresar.Location = new System.Drawing.Point(467, 166);
            btn_de_ingresar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_de_ingresar.Name = "btn_de_ingresar";
            btn_de_ingresar.Size = new System.Drawing.Size(121, 45);
            btn_de_ingresar.TabIndex = 3;
            btn_de_ingresar.Text = "Ingresar";
            btn_de_ingresar.UseVisualStyleBackColor = true;
            btn_de_ingresar.Click += btn_de_ingresar_Click;
            // 
            // Label_de_mensaje
            // 
            Label_de_mensaje.AutoSize = true;
            Label_de_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Label_de_mensaje.ForeColor = System.Drawing.Color.Red;
            Label_de_mensaje.Location = new System.Drawing.Point(240, 209);
            Label_de_mensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label_de_mensaje.Name = "Label_de_mensaje";
            Label_de_mensaje.Size = new System.Drawing.Size(170, 24);
            Label_de_mensaje.TabIndex = 4;
            Label_de_mensaje.Text = "Label_de_mensaje";
            Label_de_mensaje.Visible = false;
            // 
            // Mensaje_de_conexion
            // 
            Mensaje_de_conexion.AutoSize = true;
            Mensaje_de_conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Mensaje_de_conexion.ForeColor = System.Drawing.Color.Red;
            Mensaje_de_conexion.Location = new System.Drawing.Point(544, 18);
            Mensaje_de_conexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Mensaje_de_conexion.Name = "Mensaje_de_conexion";
            Mensaje_de_conexion.Size = new System.Drawing.Size(60, 24);
            Mensaje_de_conexion.TabIndex = 5;
            Mensaje_de_conexion.Text = "label3";
            Mensaje_de_conexion.Visible = false;
            // 
            // btn_Historial
            // 
            btn_Historial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Historial.Location = new System.Drawing.Point(220, 22);
            btn_Historial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Historial.Name = "btn_Historial";
            btn_Historial.Size = new System.Drawing.Size(197, 50);
            btn_Historial.TabIndex = 6;
            btn_Historial.Text = "Historial";
            btn_Historial.UseVisualStyleBackColor = true;
            btn_Historial.Click += btn_Historial_Click;
            // 
            // btn_hacer_reservacion
            // 
            btn_hacer_reservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_hacer_reservacion.Location = new System.Drawing.Point(425, 22);
            btn_hacer_reservacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_hacer_reservacion.Name = "btn_hacer_reservacion";
            btn_hacer_reservacion.Size = new System.Drawing.Size(217, 50);
            btn_hacer_reservacion.TabIndex = 7;
            btn_hacer_reservacion.Text = "Hacer préstamo";
            btn_hacer_reservacion.UseVisualStyleBackColor = true;
            btn_hacer_reservacion.Click += btn_hacer_reservacion_Click;
            // 
            // groupBox_de_botones
            // 
            groupBox_de_botones.Controls.Add(btn_cambiar_usuario);
            groupBox_de_botones.Controls.Add(btn_Historial);
            groupBox_de_botones.Controls.Add(btn_hacer_reservacion);
            groupBox_de_botones.Location = new System.Drawing.Point(21, 393);
            groupBox_de_botones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_de_botones.Name = "groupBox_de_botones";
            groupBox_de_botones.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_de_botones.Size = new System.Drawing.Size(699, 118);
            groupBox_de_botones.TabIndex = 8;
            groupBox_de_botones.TabStop = false;
            groupBox_de_botones.Visible = false;
            // 
            // btn_cambiar_usuario
            // 
            btn_cambiar_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_cambiar_usuario.Location = new System.Drawing.Point(7, 22);
            btn_cambiar_usuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_cambiar_usuario.Name = "btn_cambiar_usuario";
            btn_cambiar_usuario.Size = new System.Drawing.Size(197, 50);
            btn_cambiar_usuario.TabIndex = 8;
            btn_cambiar_usuario.Text = "Otro usuario";
            btn_cambiar_usuario.UseVisualStyleBackColor = true;
            btn_cambiar_usuario.Click += btn_cambiar_usuario_Click;
            // 
            // groupBox_datos_de_usuario
            // 
            groupBox_datos_de_usuario.Controls.Add(campo_p_apellido);
            groupBox_datos_de_usuario.Controls.Add(campo_s_apellido);
            groupBox_datos_de_usuario.Controls.Add(campo_nombre);
            groupBox_datos_de_usuario.Controls.Add(label5);
            groupBox_datos_de_usuario.Controls.Add(label4);
            groupBox_datos_de_usuario.Controls.Add(label3);
            groupBox_datos_de_usuario.Location = new System.Drawing.Point(164, 265);
            groupBox_datos_de_usuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_datos_de_usuario.Name = "groupBox_datos_de_usuario";
            groupBox_datos_de_usuario.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_datos_de_usuario.Size = new System.Drawing.Size(430, 135);
            groupBox_datos_de_usuario.TabIndex = 9;
            groupBox_datos_de_usuario.TabStop = false;
            groupBox_datos_de_usuario.Visible = false;
            // 
            // campo_p_apellido
            // 
            campo_p_apellido.Location = new System.Drawing.Point(211, 61);
            campo_p_apellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            campo_p_apellido.Name = "campo_p_apellido";
            campo_p_apellido.ReadOnly = true;
            campo_p_apellido.Size = new System.Drawing.Size(173, 23);
            campo_p_apellido.TabIndex = 5;
            // 
            // campo_s_apellido
            // 
            campo_s_apellido.Location = new System.Drawing.Point(211, 99);
            campo_s_apellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            campo_s_apellido.Name = "campo_s_apellido";
            campo_s_apellido.ReadOnly = true;
            campo_s_apellido.Size = new System.Drawing.Size(173, 23);
            campo_s_apellido.TabIndex = 4;
            // 
            // campo_nombre
            // 
            campo_nombre.Location = new System.Drawing.Point(211, 22);
            campo_nombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            campo_nombre.Name = "campo_nombre";
            campo_nombre.ReadOnly = true;
            campo_nombre.Size = new System.Drawing.Size(173, 23);
            campo_nombre.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(7, 93);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(164, 24);
            label5.TabIndex = 2;
            label5.Text = "Segundo apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(7, 57);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(141, 24);
            label4.TabIndex = 1;
            label4.Text = "Primer apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(7, 17);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 24);
            label3.TabIndex = 0;
            label3.Text = "Nombre:";
            // 
            // btn_encender
            // 
            btn_encender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_encender.Location = new System.Drawing.Point(556, 70);
            btn_encender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_encender.Name = "btn_encender";
            btn_encender.Size = new System.Drawing.Size(95, 26);
            btn_encender.TabIndex = 10;
            btn_encender.Text = "Encender";
            btn_encender.UseVisualStyleBackColor = true;
            btn_encender.Click += btn_encender_Click;
            // 
            // btn_apagar
            // 
            btn_apagar.Enabled = false;
            btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_apagar.Location = new System.Drawing.Point(659, 70);
            btn_apagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_apagar.Name = "btn_apagar";
            btn_apagar.Size = new System.Drawing.Size(95, 26);
            btn_apagar.TabIndex = 11;
            btn_apagar.Text = "Apagar";
            btn_apagar.UseVisualStyleBackColor = true;
            btn_apagar.Click += btn_apagar_Click;
            // 
            // Menu_de_ingreso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(791, 588);
            Controls.Add(btn_apagar);
            Controls.Add(btn_encender);
            Controls.Add(groupBox_datos_de_usuario);
            Controls.Add(groupBox_de_botones);
            Controls.Add(Mensaje_de_conexion);
            Controls.Add(Label_de_mensaje);
            Controls.Add(btn_de_ingresar);
            Controls.Add(Campo_de_id_ingreso);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Menu_de_ingreso";
            Text = "Menu_de_ingreso";
            groupBox_de_botones.ResumeLayout(false);
            groupBox_datos_de_usuario.ResumeLayout(false);
            groupBox_datos_de_usuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Campo_de_id_ingreso;
        private System.Windows.Forms.Button btn_de_ingresar;
        private System.Windows.Forms.Label Label_de_mensaje;
        private System.Windows.Forms.Label Mensaje_de_conexion;
        private System.Windows.Forms.Button btn_Historial;
        private System.Windows.Forms.Button btn_hacer_reservacion;
        private System.Windows.Forms.GroupBox groupBox_de_botones;
        private System.Windows.Forms.GroupBox groupBox_datos_de_usuario;
        private System.Windows.Forms.TextBox campo_p_apellido;
        private System.Windows.Forms.TextBox campo_s_apellido;
        private System.Windows.Forms.TextBox campo_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cambiar_usuario;
        private System.Windows.Forms.Button btn_encender;
        private System.Windows.Forms.Button btn_apagar;
    }
}
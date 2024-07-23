namespace Servidor
{
    partial class Registrar_categoria
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
            boton_de_registrar_id = new Button();
            campo_de_id = new TextBox();
            label3 = new Label();
            group_para_descripcion_y_estado = new GroupBox();
            Campo_nombre_de_categoria = new TextBox();
            label2 = new Label();
            boton_de_guardar = new Button();
            boton_de_cancelar = new Button();
            descripcion = new TextBox();
            label1 = new Label();
            group_para_descripcion_y_estado.SuspendLayout();
            SuspendLayout();
            // 
            // mensaje
            // 
            mensaje.Anchor = AnchorStyles.Left;
            mensaje.AutoSize = true;
            mensaje.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mensaje.ForeColor = Color.Red;
            mensaje.Location = new Point(341, 97);
            mensaje.Margin = new Padding(4, 0, 4, 0);
            mensaje.Name = "mensaje";
            mensaje.Size = new Size(190, 18);
            mensaje.TabIndex = 18;
            mensaje.Text = "*Solo se aceptan números*";
            mensaje.Visible = false;
            // 
            // boton_de_registrar_id
            // 
            boton_de_registrar_id.Anchor = AnchorStyles.Left;
            boton_de_registrar_id.Location = new Point(332, 137);
            boton_de_registrar_id.Margin = new Padding(4, 3, 4, 3);
            boton_de_registrar_id.Name = "boton_de_registrar_id";
            boton_de_registrar_id.Size = new Size(250, 55);
            boton_de_registrar_id.TabIndex = 14;
            boton_de_registrar_id.Text = "Registrar y continuar";
            boton_de_registrar_id.UseVisualStyleBackColor = true;
            boton_de_registrar_id.Click += boton_de_registrar_id_Click;
            // 
            // campo_de_id
            // 
            campo_de_id.Anchor = AnchorStyles.Left;
            campo_de_id.Location = new Point(492, 54);
            campo_de_id.Margin = new Padding(4, 3, 4, 3);
            campo_de_id.Name = "campo_de_id";
            campo_de_id.Size = new Size(234, 23);
            campo_de_id.TabIndex = 17;
            campo_de_id.TextChanged += campo_de_id_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(214, 48);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(233, 24);
            label3.TabIndex = 16;
            label3.Text = "Identificación de categoría:";
            // 
            // group_para_descripcion_y_estado
            // 
            group_para_descripcion_y_estado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            group_para_descripcion_y_estado.Controls.Add(Campo_nombre_de_categoria);
            group_para_descripcion_y_estado.Controls.Add(label2);
            group_para_descripcion_y_estado.Controls.Add(boton_de_guardar);
            group_para_descripcion_y_estado.Controls.Add(boton_de_cancelar);
            group_para_descripcion_y_estado.Controls.Add(descripcion);
            group_para_descripcion_y_estado.Controls.Add(label1);
            group_para_descripcion_y_estado.Enabled = false;
            group_para_descripcion_y_estado.Location = new Point(30, 200);
            group_para_descripcion_y_estado.Margin = new Padding(4, 3, 4, 3);
            group_para_descripcion_y_estado.Name = "group_para_descripcion_y_estado";
            group_para_descripcion_y_estado.Padding = new Padding(4, 3, 4, 3);
            group_para_descripcion_y_estado.Size = new Size(882, 299);
            group_para_descripcion_y_estado.TabIndex = 13;
            group_para_descripcion_y_estado.TabStop = false;
            group_para_descripcion_y_estado.Text = "Datos adicionales";
            // 
            // Campo_nombre_de_categoria
            // 
            Campo_nombre_de_categoria.Location = new Point(251, 45);
            Campo_nombre_de_categoria.Margin = new Padding(4, 3, 4, 3);
            Campo_nombre_de_categoria.MaxLength = 25;
            Campo_nombre_de_categoria.Name = "Campo_nombre_de_categoria";
            Campo_nombre_de_categoria.Size = new Size(234, 23);
            Campo_nombre_de_categoria.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 39);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 24);
            label2.TabIndex = 7;
            label2.Text = "Nombre de categoría:";
            // 
            // boton_de_guardar
            // 
            boton_de_guardar.Location = new Point(692, 226);
            boton_de_guardar.Margin = new Padding(4, 3, 4, 3);
            boton_de_guardar.Name = "boton_de_guardar";
            boton_de_guardar.Size = new Size(183, 55);
            boton_de_guardar.TabIndex = 6;
            boton_de_guardar.Text = "Guardar";
            boton_de_guardar.UseVisualStyleBackColor = true;
            boton_de_guardar.Click += boton_de_guardar_Click;
            // 
            // boton_de_cancelar
            // 
            boton_de_cancelar.Location = new Point(22, 237);
            boton_de_cancelar.Margin = new Padding(4, 3, 4, 3);
            boton_de_cancelar.Name = "boton_de_cancelar";
            boton_de_cancelar.Size = new Size(183, 55);
            boton_de_cancelar.TabIndex = 5;
            boton_de_cancelar.Text = "Cancelar";
            boton_de_cancelar.UseVisualStyleBackColor = true;
            boton_de_cancelar.Click += boton_de_cancelar_Click;
            // 
            // descripcion
            // 
            descripcion.Location = new Point(172, 122);
            descripcion.Margin = new Padding(4, 3, 4, 3);
            descripcion.MaxLength = 150;
            descripcion.Multiline = true;
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(577, 95);
            descripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 119);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 24);
            label1.TabIndex = 0;
            label1.Text = "Descripción:";
            // 
            // Registrar_categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(mensaje);
            Controls.Add(boton_de_registrar_id);
            Controls.Add(campo_de_id);
            Controls.Add(label3);
            Controls.Add(group_para_descripcion_y_estado);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Registrar_categoria";
            Text = "Registrar_categoria";
            group_para_descripcion_y_estado.ResumeLayout(false);
            group_para_descripcion_y_estado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.Button boton_de_registrar_id;
        private System.Windows.Forms.TextBox campo_de_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox group_para_descripcion_y_estado;
        private System.Windows.Forms.Button boton_de_guardar;
        private System.Windows.Forms.Button boton_de_cancelar;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Campo_nombre_de_categoria;
        private System.Windows.Forms.Label label2;
    }
}
/*
Universidad Estatal a Distancia
Cátedra de informática
Primer cuatrimestre 2024
Nombre del estudiante: Andrés Quesada Rodríguez
Id: 117240124
Sede: Parrita 02.
Segundo proyecto a realizar.
 */
using Capa_de_entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

using Usuario.Clases;

using Newtonsoft.Json;
using System.Threading;

using System.Collections.Generic;

namespace Usuario.Interfaces
{
    public partial class Menu_de_ingreso : Form
    {
        private tcp_usuario conexion_tcp = new tcp_usuario();
        private static Cliente objeto_cliente;

        bool cliente_conectado = false;

        public Menu_de_ingreso()
        {
            InitializeComponent();
        }

        #region Campo de ID que valida datos en solo números
        private void Campo_de_id_ingreso_TextChanged(object sender, EventArgs e)
        {
            string verificar_numeros = Campo_de_id_ingreso.Text;
            if (!int.TryParse(verificar_numeros, out _))
            {
                Label_de_mensaje.Visible = true;
                Label_de_mensaje.Text = "*El campo no puede contener texto ";
                btn_de_ingresar.Enabled = false;
            }
            else
            {
                btn_de_ingresar.Enabled = true;
                Label_de_mensaje.Visible = false;

                if (string.IsNullOrEmpty(verificar_numeros))
                {
                    Label_de_mensaje.Visible = true;
                    Label_de_mensaje.Text = "*El campo no puede quedar vacío ";
                    btn_de_ingresar.Enabled = false;
                }
            }
        }
        #endregion

        #region Botón de ingresar con ID
        private async void btn_de_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                await conexion_tcp.EnviarMensajeAsync(2, Campo_de_id_ingreso.Text);

                objeto_cliente = JsonConvert.DeserializeObject<Cliente>(conexion_tcp.recibir_mensaje());

                if (Campo_de_id_ingreso.Text == "" || Campo_de_id_ingreso.Text == null) 
                {
                    Label_de_mensaje.Visible = true;
                    Label_de_mensaje.Text = "*El campo se encuentra vació.";
                }
                else if (objeto_cliente == null)
                {
                    Label_de_mensaje.Visible = true;
                    Label_de_mensaje.Text = "*El usuario no se encuentra registrado";
                    btn_de_ingresar.Enabled = false;
                }
                else
                {
                    groupBox_datos_de_usuario.Visible = true;
                    groupBox_de_botones.Visible = true;
                    btn_de_ingresar.Enabled = false;
                    Campo_de_id_ingreso.Enabled = false;

                    campo_nombre.Text = objeto_cliente.Nombre;
                    campo_p_apellido.Text = objeto_cliente.Primer_apellido;
                    campo_s_apellido.Text = objeto_cliente.Segundo_apellido;

                    conexion_tcp.enviar_mensaje(1, $"Se logeo el usuario: {objeto_cliente.Identificacion}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex);
            }
        }
        #endregion

        
        #region Botón de abrir historial
        private Historial abrir_historial;
        private void btn_Historial_Click(object sender, EventArgs e)
        {
            if (abrir_historial == null)
            {
                 conexion_tcp.enviar_mensaje(3, objeto_cliente.Id_Cliente.ToString());

                string mensajeRecibido = conexion_tcp.recibir_mensaje();
                List<Prestamo> lista = JsonConvert.DeserializeObject<List<Prestamo>>(mensajeRecibido);

                if (lista != null)
                {
                    conexion_tcp.enviar_mensaje(1, $"El usuario {objeto_cliente.Id_Cliente}, accede a historial");
                    abrir_historial = new Historial();
                    abrir_historial.Instancia_clases_de_id_y_conexion(conexion_tcp, objeto_cliente);
                    abrir_historial.FormClosed += new FormClosedEventHandler(volver_abrir1);
                    abrir_historial.Show();
                }
                else { MessageBox.Show($"No hay datos de historial para este cliente"); }
            }
        }
        private void volver_abrir1(object sender, EventArgs e) { abrir_historial = null; }
        #endregion

        #region Botón de abrir pedidos
        private Pedido_Articulos abrir_pedidos_de_articulos;
        private void btn_hacer_reservacion_Click(object sender, EventArgs e)
        {
             conexion_tcp.enviar_mensaje(7, "");

            String datos_obtenidos = conexion_tcp.recibir_mensaje();

            bool deserializado = JsonConvert.DeserializeObject<bool>(datos_obtenidos);


            if (deserializado)
            {
                MessageBox.Show("No hay datos para registrar todavía.");
            }
            else
            {
                conexion_tcp.enviar_mensaje(1, $"El usuario {objeto_cliente.Id_Cliente}, accede a pedidos");
                abrir_pedidos_de_articulos = new Pedido_Articulos();
                abrir_pedidos_de_articulos.instanciar_elementos_conexion_cliente(conexion_tcp, objeto_cliente);
                abrir_pedidos_de_articulos.FormClosed += new FormClosedEventHandler(volver_abrir2);
                abrir_pedidos_de_articulos.Show();
            }
        }
        private void volver_abrir2(object sender, EventArgs e) { abrir_pedidos_de_articulos = null; }
        #endregion

        #region Botón de cambiar usuario
        private void btn_cambiar_usuario_Click(object sender, EventArgs e)
        {
            groupBox_datos_de_usuario.Visible = false;
            groupBox_de_botones.Visible = false;
            Campo_de_id_ingreso.Text = string.Empty;
            Campo_de_id_ingreso.Enabled = true;
            btn_de_ingresar.Enabled = true;
        }
        #endregion

        #region Botones de apagado/encendido
        private void btn_encender_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() =>
            {
                conexion_tcp.empezar_conexion();
                this.Invoke((MethodInvoker)delegate
                {
                    Mensaje_de_conexion.Text = "*En linea.";
                    Mensaje_de_conexion.ForeColor = Color.Green;
                    Mensaje_de_conexion.Visible = true;
                    btn_apagar.Enabled = true;
                    btn_encender.Enabled = false;
                    Campo_de_id_ingreso.Enabled = true;

                });
                
            });
            cliente_conectado = true;
            thread.Start();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            cliente_conectado = conexion_tcp.cerrar_conexion();
            Mensaje_de_conexion.Text = "*Fuera de conexión.";
            Mensaje_de_conexion.ForeColor = Color.Red;
            Mensaje_de_conexion.Visible = true;
            btn_apagar.Enabled = false;
            btn_encender.Enabled = true;
            Campo_de_id_ingreso.Enabled = false;

            btn_de_ingresar.Enabled = false;

            groupBox_datos_de_usuario.Visible = false;
            groupBox_de_botones.Visible = false;
            conexion_tcp.enviar_mensaje(1, $"El usuario {objeto_cliente.Id_Cliente}, desconectado");
        }
        #endregion
    }
}

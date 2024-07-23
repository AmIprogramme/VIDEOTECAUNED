/*
Universidad Estatal a Distancia
Cátedra de informática
Primer cuatrimestre 2024
Nombre del estudiante: Andrés Quesada Rodríguez
Id: 117240124
Sede: Parrita 02.
Segundo proyecto a realizar.
 */
using System.Net.Sockets;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Capa_de_entidades;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Usuario.Clases
{
    public class tcp_usuario
    {
        private static IPAddress? ipServidor;
        private static TcpClient? cliente;
        private static IPEndPoint? serverEndPoint;
        private static StreamWriter? clienteSW;
        private static StreamReader? clienteSR;

        public tcp_usuario()
        {
        }

        #region Empezar conexión
        public bool empezar_conexion()
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                cliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 30000);
                cliente.Connect(serverEndPoint);
                clienteSW = new StreamWriter(cliente.GetStream()) { AutoFlush = true };
                clienteSR = new StreamReader(cliente.GetStream());
                
            }
            catch (SocketException ex)
            {
                Console.WriteLine($"Error al intentar conectar: {ex.Message}");
            }
            return true;
        }
        #endregion
        public async Task<string> recibir_mensaje_async()
        {
            try
            {
                return await clienteSR!.ReadLineAsync() ?? string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en RecibirMensajeAsync(): {ex.Message}");
                return string.Empty;
            }
        }

        public string recibir_mensaje()
        {
            try
            {
                return  clienteSR?.ReadLine() ?? string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en RecibirMensajeAsync(): {ex.Message}");
                return string.Empty;
            }
        }
        #region Enviar mensaje asincrono
        public async Task EnviarMensajeAsync(int metodo, string datosParaElServidor)
        {
            try
            {
                var mensaje = new MensajeSocket<object>
                {
                    Metodo = metodo,
                    Entidad = datosParaElServidor
                };
                if (clienteSW != null)
                {
                    await clienteSW.WriteLineAsync(JsonConvert.SerializeObject(mensaje));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en EnviarMensajeAsync(): {ex.Message}");
            }
        }
        #endregion

        public void enviar_mensaje(int metodo, string datosParaElServidor)
        {
            try
            {
                var mensaje = new MensajeSocket<object>
                {
                    Metodo = metodo,
                    Entidad = datosParaElServidor
                };
                if (clienteSW != null)
                {
                     clienteSW.WriteLine(JsonConvert.SerializeObject(mensaje));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en EnviarMensajeAsync(): {ex.Message}");
            }
        }

        #region Cerrar conexión
        public bool cerrar_conexion()
        {
            try
            {
                clienteSR?.Close();
                clienteSW?.Close();
                cliente?.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción en la función cerrar_conexion: {ex.StackTrace}");
            }
            return false;
        }
        #endregion
    }
}

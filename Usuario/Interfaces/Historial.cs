/*
Universidad Estatal a Distancia
Cátedra de informática
Primer cuatrimestre 2024
Nombre del estudiante: Andrés Quesada Rodríguez
Id: 117240124
Sede: Parrita 02.
Segundo proyecto a realizar.
 */

using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_entidades;
using Newtonsoft.Json;
using Usuario.Clases;

namespace Usuario.Interfaces
{
    public partial class Historial : Form
    {
        
        private static Cliente instancia_cliente = new Cliente();
        private static tcp_usuario conexion = new tcp_usuario();

        public Historial()
        {
            InitializeComponent();
            
            Task.Run(() => Llenar_tabla());
          
        }
        protected async Task Llenar_tabla()
        {
            try
            {
                await conexion.EnviarMensajeAsync(3, instancia_cliente.Id_Cliente.ToString());

                string mensajeRecibido = conexion.recibir_mensaje();
                List<Prestamo> lista = JsonConvert.DeserializeObject<List<Prestamo>>(mensajeRecibido);

                if (lista != null) 
                {
                    foreach (Prestamo p in lista)
                    {
                        if (p == null) 
                        { break; }

                        // Verifica el contenido de los datos deserializados
                        String peliculaId = p._Pelicula.Id_de_pelicula.ToString();
                        String titulo = p._Pelicula.Titulo;
                        String Anio = p._Pelicula.Ano_de_lanzamiento.ToString();
                        String idioma = p._Pelicula.Idioma;
                        String id_categoria = p._Pelicula.Categoria_pelicula.Id_de_categoria.ToString();
                        String nombre = p._Pelicula.Categoria_pelicula.Nombre_de_la_categoria;
                        String fecha = p.Fecha_de_prestamo.ToString();
                        String pendiente = string.Empty;

                        if (p.Pendiente_de_devolucion)
                        {
                            pendiente = "Si";
                        }
                        else { pendiente = "No"; }

                        // Accede a los controles de la UI de manera segura
                        if (tabla_de_historial.InvokeRequired)
                        {
                            tabla_de_historial.Invoke(new Action(() =>
                            {
                                tabla_de_historial.Rows.Add(peliculaId, titulo, Anio, idioma, id_categoria, nombre, fecha, pendiente);
                            }));
                        }
                        else
                        {
                            tabla_de_historial.Rows.Add(peliculaId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción de tipo {ex}");
            }
        }
        public void Instancia_clases_de_id_y_conexion(tcp_usuario tcp, Cliente c)
        {
            conexion = tcp;
            instancia_cliente = c;
            campo_nombre.Text = instancia_cliente.Nombre;
            campo_P_Apellido.Text = instancia_cliente.Primer_apellido;
            Campo_S_Apellido.Text = instancia_cliente.Segundo_apellido;
            
        }        
    }
}

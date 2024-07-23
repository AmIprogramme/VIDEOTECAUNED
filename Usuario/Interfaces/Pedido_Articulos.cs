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
using System.Windows.Forms;
using Capa_de_entidades;

using Usuario.Clases;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;

using System.Threading;


namespace Usuario.Interfaces
{
    public partial class Pedido_Articulos : Form
    {
        private static tcp_usuario conexion = new tcp_usuario();
        private static Cliente objeto_cliente = new Cliente();

        private static List<Sucursal> lista_sucursales = new List<Sucursal>();
        private static List<PeliculaxSucursal> lista_pxs = new List<PeliculaxSucursal>();
        private static List<Pelicula> lista_filmes = new List<Pelicula>();  

        public Pedido_Articulos()
        {
            InitializeComponent();
            Task.Run(() => llenar_datos_del_cliente());
        }
        
        public void instanciar_elementos_conexion_cliente(tcp_usuario tcp, Cliente c)
        {
            conexion = tcp;
            objeto_cliente = c;
        }

        private void actualizar_lista_de_pxs() 
        {
            try
            {
                conexion.enviar_mensaje(4, "");
                String datos_obtenidos = conexion.recibir_mensaje();

                var deserializado = JsonConvert.DeserializeObject<Dictionary<string, object>>(datos_obtenidos);

                // Deserializar cada entrada del diccionario a las listas respectivas
                lista_pxs = JsonConvert.DeserializeObject<List<PeliculaxSucursal>>(deserializado["Lista2"].ToString());
                lista_filmes = JsonConvert.DeserializeObject<List<Pelicula>>(deserializado["Lista3"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción de tipo: {ex}");
                this.Close();
            }
        }

        private async Task llenar_datos_del_cliente()
        {
            try
            {
                await conexion.EnviarMensajeAsync(4, "");

                String datos_obtenidos = conexion.recibir_mensaje();

                var deserializado = JsonConvert.DeserializeObject<Dictionary<string, object>>(datos_obtenidos);

                // Deserializar cada entrada del diccionario a las listas respectivas
                lista_sucursales = JsonConvert.DeserializeObject<List<Sucursal>>(deserializado["Lista1"].ToString());
                lista_pxs = JsonConvert.DeserializeObject<List<PeliculaxSucursal>>(deserializado["Lista2"].ToString());
                lista_filmes = JsonConvert.DeserializeObject<List<Pelicula>>(deserializado["Lista3"].ToString());

                foreach (Sucursal s in lista_sucursales)
                {
                    int id_sucursal = s.Id_de_sucursal;
                    if (comboBox_de_sucursales.InvokeRequired)
                    {
                        comboBox_de_sucursales.Invoke(new Action(() =>
                        {
                            comboBox_de_sucursales.Items.Add(id_sucursal);
                        }));
                    }
                    else
                    {
                        comboBox_de_sucursales.Items.Add(id_sucursal);
                    }
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Excepción de tipo: {ex}");
                this.Close();
            }
        }
        private void comboBox_de_hoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipo_de_excepcion = 0;
            actualizar_lista_de_pxs();
            try
            {
                int seleccion = Convert.ToInt32(comboBox_de_sucursales.SelectedItem.ToString());
                Sucursal sc = lista_sucursales.FirstOrDefault(p => p.Id_de_sucursal == seleccion);

                campo_de_nombre.Text = sc.Nombre;
                campo_de_direccion.Text = sc.Direccion;
                campo_de_telefono.Text = sc.Telefono;

                llenar_datos_de_tabla(seleccion);
            }
            catch (Exception ex)
            {
                switch (tipo_de_excepcion)
                {
                    case 1:
                        MessageBox.Show("No hay más elementos");

                        break;
                    case 2:
                        MessageBox.Show("No hay registros de este hotel");
                        break;
                    default:
                        MessageBox.Show($"Excepción de tipo: {ex}");

                        break;
                }
            }

        }

        private void llenar_datos_de_tabla(int id_sucursal)
        {
            tabla_de_pedidos.Rows.Clear();
            actualizar_lista_de_pxs();

            foreach (PeliculaxSucursal p in lista_pxs)
            {
                if (p.Cantidad != 0 && p.Sucursal.Id_de_sucursal == id_sucursal)
                {
                    tabla_de_pedidos.Rows.Add(p.Filmes.Id_de_pelicula, p.Filmes.Titulo,
                        p.Filmes.Ano_de_lanzamiento, p.Filmes.Idioma, p.Filmes.Categoria_pelicula.Nombre_de_la_categoria);
                }
            }

        }
        private async void btn_guardar_Click(object sender, EventArgs e)
        {
            List<Prestamo> lista_global = new List<Prestamo>();
            List<String> lista_de_disminucion = new List<String>();

            try
            {
                int seleccion = Convert.ToInt32(comboBox_de_sucursales.SelectedItem.ToString());
                Sucursal sc = lista_sucursales.FirstOrDefault(p => p.Id_de_sucursal == seleccion);

                
                if (comboBox_de_sucursales.SelectedIndex == -1)
                {
                    throw new Exception("No se ha seleccionado ninguna sucursal.");
                }

                for (int i = 0; i < tabla_de_pedidos.Rows.Count; i++)
                {
                    if (tabla_de_pedidos.Rows[i].Cells[5].EditedFormattedValue != null)
                    {
                        bool evaluardo_de_cheked = (bool)tabla_de_pedidos.Rows[i].Cells[5].EditedFormattedValue;
                        if (evaluardo_de_cheked)
                        {
                            Pelicula filmes = lista_filmes.FirstOrDefault(P => P.Id_de_pelicula == Convert.ToInt32(tabla_de_pedidos.Rows[i].Cells[0].Value.ToString()));
                            Prestamo l = new Prestamo(0, objeto_cliente, sc, filmes, DateTime.Now, true);

                            String query = "UPDATE PeliculaxSucursal" +
                                " SET Cantidad = CASE " +
                                " WHEN cantidad - 1 < 0 THEN 0 " +
                                " ELSE cantidad - 1 " +
                                " END " +
                                " WHERE IdSucursal = "+sc.Id_de_sucursal+ " " +
                                " And IdPelicula = "+filmes.Id_de_pelicula+";";

                            lista_de_disminucion.Add(query);

                            lista_global.Add(l);
                        }
                    }
                }

                String lista_de_datos = JsonConvert.SerializeObject(lista_global);
                await conexion.EnviarMensajeAsync(5, lista_de_datos);

                String mensaje_proveniente_de_servidor = await conexion.recibir_mensaje_async();

                MensajeSocket<object> O_servidor = JsonConvert.DeserializeObject<MensajeSocket<object>>(mensaje_proveniente_de_servidor);

                if (O_servidor.Metodo == 1) 
                {
                    String paquete_de_disminucion_cantidad = JsonConvert.SerializeObject(lista_de_disminucion);
                    await conexion.EnviarMensajeAsync(6, paquete_de_disminucion_cantidad);
                }

                Thread.Sleep(300);

                MessageBox.Show(O_servidor.Entidad.ToString());
                tabla_de_pedidos.Rows.Clear();
                comboBox_de_sucursales.Items.Clear();   
                await llenar_datos_del_cliente();
                btn_guardar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción de tipo: " + ex.Message);
            }
        }

        private void tabla_de_pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool banderazo = false;

            actualizar_lista_de_pxs();
            // Verificar que se haya seleccionado al menos una película

            for (int i = 0; i < tabla_de_pedidos.Rows.Count; i++)
            {
                if (tabla_de_pedidos.Rows[i].Cells[5].EditedFormattedValue != null)
                {
                    bool es_true = (bool)tabla_de_pedidos.Rows[i].Cells[5].EditedFormattedValue;
                    if (es_true)
                    {
                        banderazo = true;
                        break;
                    }
                }
            }

            if (banderazo)
            { btn_guardar.Enabled = true; }
            else
            { btn_guardar.Enabled = false; }

        }
    }
}


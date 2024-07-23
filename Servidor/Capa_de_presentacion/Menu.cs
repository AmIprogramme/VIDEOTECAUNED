/*
Universidad Estatal a Distancia
Cátedra de informática
Segundo cuatrimestre 2024
Nombre del estudiante: Andrés Quesada Rodríguez
Id: 117240124
Sede: Parrita 02.
Segundo proyecto a realizar.
 
 
El código de la parte de TCP cliente-servidor es de pertenenecía a Johan Manuel Acosta 
 
Bibliografía:

Cátedra Tecnología de Sistemas /Informática UNED CR. (2024, 12 julio). 
Sesión virtual 2 09 julio 2024 Johan Manuel Acosta Ibañez 
[Vídeo]. YouTube. https://www.youtube.com/watch?v=Mr_aJGyyY6Y
 
 */


using Capa_de_Acceso_a_Datos;
using Servidor.Capa_de_presentacion.Consultas;
using Capa_de_entidades;
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Net;

namespace Servidor
{
    public partial class Menu : Form
    {
        Gestor_de_registros gestor = new Gestor_de_registros();
        TcpListener tcpListener;
        Thread subprocesoEscuchaClientes;
        EscribirEnTextboxDelegado modificarTextotxtBitacora;
        ModificarListBoxDelegado modificarListBoxClientes;
        bool servidorIniciado;
        // Declarar el semáforo con un contador inicial de 1 y un máximo de 1 para permitir un solo acceso a la vez.
        private static Semaphore semaphore = new Semaphore(1, 1);

        private delegate void EscribirEnTextboxDelegado(String texto);
        private delegate void ModificarListBoxDelegado(String texto, bool agregar);
        public Menu()
        {
            InitializeComponent();
            //modificarTextotxtBitacora = new EscribirEnTextboxDelegado(EscribirEnTextBox);
            modificarListBoxClientes = new ModificarListBoxDelegado(ModificarListBox);
        }

        private void ModificarListBox(string texto, bool agregar)
        {
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(modificarListBoxClientes, texto, agregar);
            }
            else
            {
                if (agregar)
                {
                    listView1.Items.Add(texto);
                }
                else
                {
                    var itemToRemove = listView1.Items.Cast<ListViewItem>().FirstOrDefault(i => i.Text == texto);
                    if (itemToRemove != null)
                    {
                        listView1.Items.Remove(itemToRemove);
                    }
                }
            }
        }

        #region Registros 

            #region Abrir registro de categoría

        /*Este código maneja la lógica para abrir un formulario de registro de categoría (Registrar_categoria). 
          Cuando el botón btn_registrar_categoria es clicado:

        1- Verifica si ya hay una instancia del formulario abierta.

        2- Verifica si hay datos de encargados registrados (a través de gestor_de_datos.Contador_1).
        
        3- Si ambas condiciones se cumplen, crea y muestra el formulario, pasando los datos necesarios y 
        suscribiéndose al evento de cierre del formulario.

        4- Si no hay datos de encargados, muestra un mensaje de advertencia.

        5- Cuando el formulario se cierra, el método volver_abrir1 se ejecuta, estableciendo la instancia del formulario 
        a null para permitir abrirlo nuevamente en el futuro.*/

        Registrar_categoria abrir_categoria;

        private void btn_registrar_categoria_Click(object sender, EventArgs e)
        {
            if (abrir_categoria == null)
            {
                abrir_categoria = new Registrar_categoria();
                abrir_categoria.FormClosed += new FormClosedEventHandler(volver_abrir1!);
                abrir_categoria.Show();
            }
        }
        void volver_abrir1(object sender, EventArgs e) { abrir_categoria = null!; }
        #endregion

            #region Abrir registro de pelicula
        Registrar_pelicula abrir_R_Pelicula;
        private void btn_registrar_pelicula_Click(object sender, EventArgs e)
        {
            String query = "Select * from CategoriaPelicula";
            if (abrir_R_Pelicula == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query)))
                {
                    abrir_R_Pelicula = new Registrar_pelicula();
                    abrir_R_Pelicula.FormClosed += new FormClosedEventHandler(volver_abrir2!);
                    abrir_R_Pelicula.Show();
                }
                else
                {
                    MessageBox.Show("Tiene que llenar datos de categoría antes de poder acceder" +
                        "\na este campo.");
                }
            }
        }
        void volver_abrir2(object sender, EventArgs e) { abrir_R_Pelicula = null!; }



        #endregion

            #region // Abrir registro de encargado

        Registrar_encargado abrir_R_encargado;
        private void btn_registrar_encargado_Click(object sender, EventArgs e)
        {
            String query = "Select * from Persona";

            if (abrir_R_encargado == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query)))
                {
                    abrir_R_encargado = new Registrar_encargado();
                    abrir_R_encargado.FormClosed += new FormClosedEventHandler(volver_abrir3!);
                    abrir_R_encargado.Show();
                }
                else
                {
                    MessageBox.Show("Tiene que llenar datos de Persona antes de poder acceder" +
                        "\na este campo.");
                }
            }

        }
        void volver_abrir3(object sender, EventArgs e) { abrir_R_encargado = null!; }

        #endregion

            #region // Abrir registro de sucursal
        Registrar_sucursal abrir_R_Sucursal;
        private void btn_registrar_sucursal_Click(object sender, EventArgs e)
        {
            String query = "Select * from Encargado";
            if (abrir_R_Sucursal == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query)))
                {
                    abrir_R_Sucursal = new Registrar_sucursal();
                    abrir_R_Sucursal.FormClosed += new FormClosedEventHandler(volver_abrir4!);
                    abrir_R_Sucursal.Show();
                }
                else
                {
                    MessageBox.Show("Tiene que llenar datos de Encargado antes de poder acceder" +
                        "\na este campo.");
                }

            }
        }
        void volver_abrir4(object sender, EventArgs e) { abrir_R_Sucursal = null!; }

        #endregion

            #region // Abrir registrar clientes

        Registrar_cliente abrir_R_Cliente;
        private void btn_registrar_cliente_Click(object sender, EventArgs e)
        {
            String query = "Select * from Persona";
            if (abrir_R_Cliente == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query)))
                {
                    abrir_R_Cliente = new Registrar_cliente();
                    abrir_R_Cliente.FormClosed += new FormClosedEventHandler(volver_abrir5!);
                    abrir_R_Cliente.Show();
                }
                else
                {
                    MessageBox.Show("Tiene que llenar datos de Persona antes de poder acceder" +
                        "\na este campo.");
                }
            }
        }
        void volver_abrir5(object sender, EventArgs e) { abrir_R_Cliente = null!; }

        #endregion

            #region // Abrir registrar peliculas por sucursal
        Registrar_peliculaxsucursal abrir_R_Peliculaxsucursal;
        private void btn_registrar_peliculaxsurcusal_Click(object sender, EventArgs e)
        {


            String query_1 = "Select * from Sucursal";
            String query_2 = "Select * from Pelicula";

            if (abrir_R_Peliculaxsucursal == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query_1)) && !(gestor.busqueda_de_existencia_id(query_2)))
                {
                    abrir_R_Peliculaxsucursal = new Registrar_peliculaxsucursal();
                    abrir_R_Peliculaxsucursal.FormClosed += new FormClosedEventHandler(volver_abrir6!);
                    abrir_R_Peliculaxsucursal.Show();
                }
                else
                {
                    MessageBox.Show("Tiene que llenar datos de Sucursal y Pelicula antes de poder acceder" +
                        "\na este campo.");
                }
            }

        }
        void volver_abrir6(object sender, EventArgs e) { abrir_R_Peliculaxsucursal = null!; }


        #endregion
            
            #region // Abrir registro de persona

        Registrar_persona abrir_R_persona;
        private void registrar_persona_Click(object sender, EventArgs e)
        {
            if (abrir_R_persona == null)
            {

                abrir_R_persona = new Registrar_persona();
                abrir_R_persona.FormClosed += new FormClosedEventHandler(volver_abrir_Persona!);
                abrir_R_persona.Show();
            }

        }
        void volver_abrir_Persona(object sender, EventArgs e) { abrir_R_persona = null!; }

        #endregion

        #endregion
        
        #region Consultas

        #region // Abrir consulta de categoría
        Consultar_categoria abrir_C_categoria;
        private void btn_consulta_categoria_Click(object sender, EventArgs e)
        {
            String query = "Select * from CategoriaPelicula";
            if (abrir_C_categoria == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query)))
                {
                    abrir_C_categoria = new Consultar_categoria();
                    abrir_C_categoria.FormClosed += new FormClosedEventHandler(volver_abrir7!);
                    abrir_C_categoria.Show();
                }
                else
                {
                    MessageBox.Show("No hay datos que mostrar.");
                }
            }
        }
        void volver_abrir7(object sender, EventArgs e) { abrir_C_categoria = null!; }


        #endregion

            #region // Abrir consulta de peliculas
        Consultar_pelicula abrir_C_pelicula;

        private void btn_consulta_pelicula_Click(object sender, EventArgs e)
        {
            String query = "Select * from Pelicula";
            if (abrir_C_pelicula == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query)))
                {
                    abrir_C_pelicula = new Consultar_pelicula();
                    abrir_C_pelicula.FormClosed += new FormClosedEventHandler(volver_abrir8!);
                    abrir_C_pelicula.Show();
                }
                else
                {
                    MessageBox.Show("No hay datos que mostrar.");
                }
            }
        }
        void volver_abrir8(object sender, EventArgs e) { abrir_C_pelicula = null!; }

        #endregion

            #region // Abrir consulta de encargado
        Consultar_encargado abrir_consulta_de_encargado;
        private void btn_consultar_encargado_Click(object sender, EventArgs e)
        {
            String query = "Select * from Encargado";
            if (abrir_consulta_de_encargado == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query)))
                {
                    abrir_consulta_de_encargado = new Consultar_encargado();
                    abrir_consulta_de_encargado.FormClosed += new FormClosedEventHandler(volver_abrir9!);
                    abrir_consulta_de_encargado.Show();
                }
                else
                {
                    MessageBox.Show("No hay datos que mostrar.");
                }
            }
        }
        void volver_abrir9(object sender, EventArgs e) { abrir_consulta_de_encargado = null!; }


        #endregion

            #region // Abrir consulta de sucursal
        Consultar_sucursal abrir_consulta_de_sucursal;

        private void btn_consultar_sucursal_Click(object sender, EventArgs e)
        {
            String query = "Select * from Sucursal";
            if (abrir_consulta_de_sucursal == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query)))
                {
                    abrir_consulta_de_sucursal = new Consultar_sucursal();
                    abrir_consulta_de_sucursal.FormClosed += new FormClosedEventHandler(volver_abrir10!);
                    abrir_consulta_de_sucursal.Show();
                }
                else
                {
                    MessageBox.Show("No hay datos que mostrar.");
                }
            }
        }
        void volver_abrir10(object sender, EventArgs e) { abrir_consulta_de_sucursal = null!; }
        #endregion

            #region // Abrir consulta de cliente
        Consultar_cliente abrir_C_cliente;
        private void btn_consultar_cliente_Click(object sender, EventArgs e)
        {
            String query = "Select * from Cliente";
            if (abrir_C_cliente == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query)))
                {
                    abrir_C_cliente = new Consultar_cliente();
                    abrir_C_cliente.FormClosed += new FormClosedEventHandler(volver_abrir11!);
                    abrir_C_cliente.Show();
                }
                else
                {
                    MessageBox.Show("No hay datos que mostrar.");
                }
            }
        }
        void volver_abrir11(object sender, EventArgs e) { abrir_C_cliente = null!; }

        #endregion

            #region // Abrir consulta de peliculas por sucursal
        Consultar_peliculaxSucursal abrir_C_peliculaXsucursal;
        private void btn_C_peliculaxsucursal_Click(object sender, EventArgs e)
        {
            String query = "Select * from PeliculaxSucursal";
            if (abrir_C_peliculaXsucursal == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query)))
                {
                    abrir_C_peliculaXsucursal = new Consultar_peliculaxSucursal();
                    abrir_C_peliculaXsucursal.FormClosed += new FormClosedEventHandler(volver_abrir12!);
                    abrir_C_peliculaXsucursal.Show();
                }
                else
                {
                    MessageBox.Show("No hay datos que mostrar.");
                }
            }
        }
        void volver_abrir12(object sender, EventArgs e) { abrir_C_peliculaXsucursal = null!; }
        #endregion

            #region // Abrir consulta de personas
        Consultar_persona abrir_C_persona;
        private void consultar_personas_Click(object sender, EventArgs e)
        {
            String query = "Select * from Persona";
            if (abrir_C_persona == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query)))
                {
                    abrir_C_persona = new Consultar_persona();
                    abrir_C_persona.FormClosed += new FormClosedEventHandler(volver_abrir_C_Persona!);
                    abrir_C_persona.Show();
                }
                else
                {
                    MessageBox.Show("No hay datos que mostrar.");
                }
            }
        }
        void volver_abrir_C_Persona(object sender, EventArgs e) { abrir_C_persona = null!; }
        #endregion

            #region // Abrir consulta de préstamos

        Consulta_de_prestamos abrir_C_prestamos;
        private void Consultar_prestamos_Click(object sender, EventArgs e)
        {
            String query = "Select * from Prestamo";
            if (abrir_C_prestamos == null)
            {
                if (!(gestor.busqueda_de_existencia_id(query)))
                {
                    abrir_C_prestamos = new Consulta_de_prestamos();
                    abrir_C_prestamos.FormClosed += new FormClosedEventHandler(volver_abrir_C_prestamos!);
                    abrir_C_prestamos.Show();
                }
                else
                {
                    MessageBox.Show("No hay datos que mostrar.");
                }
            }
        }
        void volver_abrir_C_prestamos(object sender, EventArgs e) { abrir_C_prestamos = null!; }
        #endregion

        #endregion

        #region Funcionalidades de conexión tcp

            #region Botones de encender/apagar
        private void btn_encender_Click(object sender, EventArgs e)
        {
            IPAddress local = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(local, 30000);
            servidorIniciado = true;

            subprocesoEscuchaClientes = new Thread(Escuchar_clientes);
            subprocesoEscuchaClientes.IsBackground = true;
            subprocesoEscuchaClientes.Start();

            Mensaje_de_conexion.Text = "*En linea.";
            Mensaje_de_conexion.ForeColor = Color.Green;
            Mensaje_de_conexion.Visible = true;
            btn_apagar.Enabled = true;
            btn_encender.Enabled = false;
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            servidorIniciado = false;
            tcpListener.Stop();

            Mensaje_de_conexion.Text = "*Fuera de conexión.";
            Mensaje_de_conexion.ForeColor = Color.Red;
            Mensaje_de_conexion.Visible = true;
            btn_apagar.Enabled = false;
            btn_encender.Enabled = true;
        }
        #endregion

            #region Escuchar_cliente
        private void Escuchar_clientes()
        {
            tcpListener.Start();

            try
            {
                while (servidorIniciado)
                {
                    TcpClient cliente = tcpListener.AcceptTcpClient();

                    Thread clienteThread = new Thread(Comunicacion_con_el_cliente!);
                    clienteThread.IsBackground = true;
                    clienteThread.Start(cliente);
                }
            }
            catch (SocketException)
            {
                MessageBox.Show("Ocurrió una excepción en escucha clientes");
            }
        }
        #endregion

            #region Comunicación con el cliente
        private void Comunicacion_con_el_cliente(object clienteObj)
        {
            TcpClient tcpCliente = (TcpClient)clienteObj;
            StreamReader reader = new StreamReader(tcpCliente.GetStream());
            StreamWriter servidorSW = new StreamWriter(tcpCliente.GetStream()) { AutoFlush = true };

            try
            {
                while (servidorIniciado)
                {
                    var mensaje = reader.ReadLine();
                    if (mensaje == null) break;

                    MensajeSocket<object> mensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<object>>(mensaje)!;
                    gestor_de_acciones(mensajeRecibido!.Metodo, mensaje, ref servidorSW);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Excepción de tipo {e}");
            }
            finally
            {
                tcpCliente.Close();
            }
        }
        #endregion

            #region Gestor de acciones
        public void gestor_de_acciones(int pMetodo, string pMensaje, ref StreamWriter servidor_SW)
        {
            try
            {
                switch (pMetodo)
                {
                    case 1: // Conectarse
                        MensajeSocket<string> mensajeConectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje)!;
                        Conectar(mensajeConectar.Entidad!);
                        break;

                    case 2: // Recibir datos de cliente
                        MensajeSocket<int> id = JsonConvert.DeserializeObject<MensajeSocket<int>>(pMensaje)!;
                        consulta_de_cliente(id, servidor_SW);
                        break;

                    case 3: // Retornar lista de historial
                        MensajeSocket<int> id2 = JsonConvert.DeserializeObject<MensajeSocket<int>>(pMensaje)!;
                        Retorno_lista_historial(id2, servidor_SW);
                        break;

                    case 4: // Retornar lista de sucursales y películas por sucursal
                        Retorno_lista_de_sucursales_y_peliculasxSucursal(servidor_SW);
                        break;

                    case 5:// Registrar elementos 
                        semaphore.WaitOne();

                        try
                        {
                            // Sección crítica: realizar el préstamo
                            // Aquí va el código para registrar el préstamo
                            MensajeSocket<String> ps = JsonConvert.DeserializeObject<MensajeSocket<String>>(pMensaje)!;
                            List<Prestamo> lista = JsonConvert.DeserializeObject<List<Prestamo>>(ps.Entidad!.ToString())!;

                            Registrar_pedido_de_pelicula(lista, servidor_SW);
                        }
                        finally
                        {
                            // Liberar el semáforo
                            semaphore.Release();
                        }
                        break;
                        

                    case 6: // Disminuir inventario
                        MensajeSocket<String> query = JsonConvert.DeserializeObject<MensajeSocket<String>>(pMensaje)!;
                        List<String> queries = JsonConvert.DeserializeObject<List<String>>(query.Entidad!.ToString())!;

                        disminuir_inventario(queries);
                        break;

                    case 7: // Verificar si hay datos de sucursal

                        verificar_si_hay_datos_de_pxs(servidor_SW);
                        break;
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show($"Excepción en gestor de datos: {ex}");
            }
        }
        #endregion

            #region Otras funciones para la gestión de datos

                 #region Consultar cliente

        private void consulta_de_cliente(MensajeSocket<int> id, StreamWriter sw)
        {
            int clienteId = id.Entidad;
            List<Cliente> lista = gestor.retorno_arreglo_CLIENTE();
            Cliente cliente = lista.FirstOrDefault(p => p.Id_Cliente == clienteId)!;
            sw.WriteLine(JsonConvert.SerializeObject(cliente));

        }


        #endregion

                 #region Retornar lista de historial.
        private void Retorno_lista_historial(MensajeSocket<int> id, StreamWriter sw)
        {
            //MessageBox.Show("Si se llegó a lista de historial");
            int clienteId = id.Entidad;
            sw.WriteLine(JsonConvert.SerializeObject(gestor.retorno_lista_de_prestamo_por_id(clienteId)));
            
        }
            #endregion
        
                 #region Retornar datos de peliculaxSucursal
        private void Retorno_lista_de_sucursales_y_peliculasxSucursal(StreamWriter sw)
        {
            List<Sucursal> sucursales = gestor.retorno_arreglo_SUCURSAL();
            List<PeliculaxSucursal> pxs = gestor.retorno_lista_PELICULA_POR_SUCURSAL();
            List<Pelicula> filmes = gestor.retorno_arreglo_PELICULAS();

            var diccionario = new Dictionary<string, object>
        {
            { "Lista1", sucursales },
            { "Lista2", pxs },
            { "Lista3", filmes }
        };

            sw.WriteLine(JsonConvert.SerializeObject(diccionario));
        }
        #endregion

                 #region Evaluador de pedido repetido o existente
        private bool evaluar_elemento_repetido_o_existente(List<Prestamo> ps, StreamWriter sw)
        {
            List<PeliculaxSucursal> lista_pxs = gestor.retorno_lista_PELICULA_POR_SUCURSAL();
            List<Prestamo> lista_pedidos = gestor.retorno_lista_de_prestamo();
            MensajeSocket<object> mensaje = new MensajeSocket<object>();

            try
            {
                foreach (Prestamo p in ps)
                {
                    // Buscar la película por sucursal
                    PeliculaxSucursal? pxs = lista_pxs.FirstOrDefault(k => k.Sucursal != null
                    && k.Sucursal.Id_de_sucursal == p._Sucursal.Id_de_sucursal
                    && k.Filmes != null
                    && k.Filmes.Id_de_pelicula == p._Pelicula.Id_de_pelicula);

                    // Verificar si la película fue encontrada y si la cantidad es suficiente
                    if (pxs == null)
                    {
                        mensaje = new MensajeSocket<object>
                        {
                            Metodo = 0,
                            Entidad = $"La película: {p._Pelicula.Titulo} no se encontró en la sucursal {p._Sucursal.Nombre}."
                        };
                        sw.WriteLine(JsonConvert.SerializeObject(mensaje));
                        return false;
                    }

                    if (pxs.Cantidad == 0)
                    {
                        mensaje = new MensajeSocket<object>
                        {
                            Metodo = 0,
                            Entidad = $"La película: {pxs.Filmes.Titulo}, de la tienda {pxs.Sucursal.Nombre} se encuentra agotada. \nPor favor, vuelva a escoger toda la selección."
                        };
                        sw.WriteLine(JsonConvert.SerializeObject(mensaje));
                        return false;
                    }

                    // Verificar si el cliente ya tiene un préstamo para la misma película
                    bool yaTienePrestamo = false;

                    if (lista_pedidos != null)
                    {
                        yaTienePrestamo = lista_pedidos.Any(k => k._Cliente.Id_Cliente == p._Cliente.Id_Cliente
                        && k._Pelicula.Id_de_pelicula == p._Pelicula.Id_de_pelicula
                        && k.Pendiente_de_devolucion == p.Pendiente_de_devolucion);
                    }
                    if (yaTienePrestamo)
                    {
                        mensaje = new MensajeSocket<object>
                        {
                            Metodo = 0,
                            Entidad = $"La película: {p._Pelicula.Titulo} ya se encuentra en préstamo a su nombre."
                        };
                        sw.WriteLine(JsonConvert.SerializeObject(mensaje));
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar el mensaje de error y considera registrar el error en un archivo de log o base de datos
                MessageBox.Show($"Ocurrió un error al registrar el pedido: {ex.Message}");
            }

            return true;
        }


        #endregion

                 #region Registrar pedido de pelicula
        private void Registrar_pedido_de_pelicula(List<Prestamo> ps, StreamWriter sw)
        {
            List<PeliculaxSucursal> lista_pxs = gestor.retorno_lista_PELICULA_POR_SUCURSAL();
            MensajeSocket<object> mensaje = new MensajeSocket<object>();
            
            try
            {
                if (evaluar_elemento_repetido_o_existente(ps, sw)) 
                {
                    foreach (Prestamo p in ps)
                    {
                        String query = "Insert into Prestamo Values (" + p._Cliente.Id_Cliente + ", " +
                            " " + p._Sucursal.Id_de_sucursal + ", " + p._Pelicula.Id_de_pelicula + ", " +
                            "'" + p.Fecha_de_prestamo.ToString() + "', 1);";
                        gestor.Registrar_datos_en_sql(query);

                    }

                    mensaje = new MensajeSocket<object>
                    {
                        Metodo = 1,
                        Entidad = "Los datos se llenaron con satisfacción."
                    };

                    sw.WriteLine(JsonConvert.SerializeObject(mensaje));
                }
            }
            catch (Exception ex) { MessageBox.Show($"Ocurrio un error en registrar pedido de tipo: {ex}"); }
        }
        #endregion
        
                 #region Disminuir cantidad de inventario

        private void disminuir_inventario(List<String> query) 
        {

            foreach (String s in query) 
            {
                gestor.Registrar_datos_en_sql(s);
            }
        }

        #endregion

                 #region True o false de películas por sucursal

        private void verificar_si_hay_datos_de_pxs( StreamWriter sw) 
        {

            if (gestor.retorno_lista_PELICULA_POR_SUCURSAL() == null)
            {
                sw.WriteLine("true");
            }
            else { sw.WriteLine("false"); }
        }

        #endregion

        #endregion Fin de las funciones de gestión.

        #region Conectar
        private void Conectar(string id_Cliente)
        {
            listView1.Invoke(modificarListBoxClientes, id_Cliente, true);
        }
        #endregion

        #endregion
    }
}
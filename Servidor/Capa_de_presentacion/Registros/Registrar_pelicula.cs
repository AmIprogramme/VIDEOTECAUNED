/*
Universidad Estatal a Distancia
Cátedra de informática
Segundo cuatrimestre 2024
Nombre del estudiante: Andrés Quesada Rodríguez
Id: 117240124
Sede: Parrita 02.
Segundo proyecto a realizar.
 */


using Capa_de_Acceso_a_Datos;
using Capa_de_entidades;

namespace Servidor
{
    public partial class Registrar_pelicula : Form
    {
        private Gestor_de_registros gestor_de_datos = new Gestor_de_registros();
        private  List<CategoriaPelicula> categorias = new List<CategoriaPelicula>();
        public Registrar_pelicula()
        {
            InitializeComponent();
            llenar_datos_de_categoria();
        }

        #region // Funciones varias.
        
        public void llenar_datos_de_categoria()
        {
            categorias = gestor_de_datos.retorno_lista_CATEGORIA_PELICULAS();
            try
            {
                foreach (CategoriaPelicula e in categorias)
                {
                    comboBox_de_categoria.Items.Add(e.Id_de_categoria);
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ocurrió una excepción de tipo: {ex}"); }

        }

        public CategoriaPelicula seleccion_de_categoria(int id)
        {
            CategoriaPelicula datos_seleccionado = new CategoriaPelicula();
            try
            {
                foreach (CategoriaPelicula e in categorias)
                {
                    if (e.Id_de_categoria == id)
                    { datos_seleccionado = e; }
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ocurrió una excepción de tipo: {ex}"); }

            return datos_seleccionado;

        }
        #endregion

        #region // Elementos de modificación.
        public void limpiar_campos()
        {
            campo_de_ID.Text = string.Empty;
            campo_titulo.Text = string.Empty;

            campo_de_ID.Enabled = true;
            boton_para_continuar_registro.Enabled = true;
        }
        public void funcion_de_bloqueo_para_registro()
        {
            group_de_registros_pelicula.Enabled = false;
        }
        public void funcion_de_desbloqueo_para_registro()
        {
            group_de_registros_pelicula.Enabled = true;
        }
        public void funcion_de_desbloqueo_general()
        {
            group_de_registros_pelicula.Enabled = true;

            campo_de_ID.Enabled = true;
            boton_para_continuar_registro.Enabled = true;
        }
        public void funcion_de_bloqueo_general()
        {
            group_de_registros_pelicula.Enabled = false;

            campo_de_ID.Enabled = false;
            boton_para_continuar_registro.Enabled = false;
        }

        #endregion

        #region // Campo de texto identificación
        private void campo_de_ID_TextChanged(object sender, EventArgs e)
        {
            String verificar_numeros = campo_de_ID.Text;
            int verificar_numeros_en_int = 0;

            try
            {
                if (verificar_numeros != null)
                {
                    if (!(int.TryParse(verificar_numeros, out verificar_numeros_en_int)))
                    {
                        mensaje.Visible = true;
                        mensaje.Text = "Solo se permiten números";

                        boton_para_continuar_registro.Enabled = false;
                    }
                    else
                    {
                        mensaje.Visible = false;
                        boton_para_continuar_registro.Enabled = true;
                    }

                    if (verificar_numeros == "")
                    {
                        boton_para_continuar_registro.Enabled = false;
                        mensaje.Visible = true;
                        mensaje.Text = "Tiene que llenar el campo antes de continuar";
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ocurrió una excepción de tipo: {ex}"); }
        }

        #endregion

        #region // Botón de registro de id
        private void boton_para_continuar_registro_Click(object sender, EventArgs e)
        {
            int numero_de_id_a_registrar = 0;

            string query = String.Empty;
            try
            {
                if (campo_de_ID.Text == "" || campo_de_ID.Text == null)
                {
                    mensaje.Visible = true;
                    mensaje.Text = "*Primero tiene que llenar el campo con números para continuar";

                    boton_para_continuar_registro.Enabled = false;

                }
                else 
                {
                    numero_de_id_a_registrar = int.Parse(campo_de_ID.Text);
                    query = "SELECT * FROM Pelicula WHERE IdPelicula = " + numero_de_id_a_registrar + " ";

                    if (gestor_de_datos.busqueda_de_existencia_id(query))
                    {
                        funcion_de_desbloqueo_para_registro();
                        mensaje.Visible = false;

                        campo_de_ID.Enabled = false;
                        boton_para_continuar_registro.Enabled = false;
                    }
                    else
                    {
                        mensaje.Visible = true;
                        mensaje.Text = "*El id ya se encuentra registrado*";
                    }

                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ocurrió una excepción de tipo: {ex}"); }
        }

        #endregion

        #region // Limpiar campos
        private void boton_de_cancelar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            funcion_de_bloqueo_para_registro();
        }

        #endregion

        #region // Botón de guardar
        private void boton_de_guardar_Click(object sender, EventArgs e)
        {
            int tipo_de_excepcion = 0;
            Pelicula filme = new Pelicula();

            try
            {
                // Validación de campos requeridos
                if (string.IsNullOrWhiteSpace(campo_titulo.Text) ||
                    comboBox_de_categoria.SelectedItem == null ||
                    comboBox_de_ano.SelectedItem == null ||
                    comboBox_de_idioma.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(campo_de_ID.Text))
                {
                    tipo_de_excepcion = 1;
                    throw new Exception("Faltan datos por llenar, por favor llenar todos los campos.");
                }

                // Se declaran las variables correspondientes para extraer los datos de los campos.
                if (!int.TryParse(campo_de_ID.Text, out int identificacion))
                {
                    tipo_de_excepcion = 2;
                    throw new Exception("ID no válido.");
                }

                string titulo = campo_titulo.Text;

                if (!int.TryParse(comboBox_de_categoria.SelectedItem.ToString(), out int categoriaId))
                {
                    tipo_de_excepcion = 3;
                    throw new Exception("Categoría no válida.");
                }
                CategoriaPelicula categoria = seleccion_de_categoria(categoriaId);

                if (!int.TryParse(comboBox_de_ano.SelectedItem.ToString(), out int anio))
                {
                    tipo_de_excepcion = 4;
                    throw new Exception("Año no válido.");
                }

                // Uso seguro de SelectedItem en comboBox_de_idioma
                string idioma = comboBox_de_idioma.SelectedItem?.ToString()!;
                if (idioma == null)
                {
                    tipo_de_excepcion = 5;
                    throw new Exception("Idioma no válido.");
                }

                // Se declara las clases con sus correspondientes datos
                filme = new Pelicula(identificacion, titulo, categoria, anio, idioma);
                String query = "Insert into Pelicula values(" + filme.Id_de_pelicula + ", " + filme.Categoria_pelicula?.Id_de_categoria + ",'" + filme.Titulo + "', " + filme.Ano_de_lanzamiento + ", '" + filme.Idioma + "')";

                gestor_de_datos.Registrar_datos_en_sql(query);
                
                // Fin del proceso
                MessageBox.Show("Sus datos fueron guardados con éxito.", "Mensaje emergente");
                limpiar_campos();
                funcion_de_bloqueo_para_registro();
            }
            catch (Exception ex)
            {
                switch (tipo_de_excepcion)
                {
                    case 1:
                        MessageBox.Show(ex.Message);
                        break;
                    case 2:
                        MessageBox.Show("El campo de ID debe ser un número válido.");
                        break;
                    case 3:
                        MessageBox.Show("La categoría seleccionada no es válida.");
                        break;
                    case 4:
                        MessageBox.Show("El año seleccionado no es válido.");
                        break;
                    case 5:
                        MessageBox.Show("El idioma seleccionado no es válido.");
                        break;
                    default:
                        MessageBox.Show("Ocurrió una excepción: " + ex.Message);
                        break;
                }
            }
        }

        #endregion

        #region Selección de categoría
        private void comboBox_de_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            categorias = gestor_de_datos.retorno_lista_CATEGORIA_PELICULAS();

            if (comboBox_de_categoria.SelectedItem != null)
            {
                if (int.TryParse(comboBox_de_categoria.SelectedItem.ToString(), out int id_seleccionado))
                {
                    foreach (CategoriaPelicula el in categorias)
                    {
                        if (el.Id_de_categoria == id_seleccionado)
                        {
                            Nombre_de_categoria.Text = el.Nombre_de_la_categoria;
                            campo_descripcion_categoria.Text = el.Descripcion;
                            break; // Salir del bucle una vez que se encuentra la categoría
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El elemento seleccionado no es un ID válido.");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna categoría.");
            }
        }

        #endregion
    }
}

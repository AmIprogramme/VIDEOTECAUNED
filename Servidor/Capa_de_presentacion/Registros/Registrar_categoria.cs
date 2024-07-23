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
    public partial class Registrar_categoria : Form
    {
        private Gestor_de_registros gestor_de_datos = new Gestor_de_registros();
        public Registrar_categoria()
        {
            InitializeComponent();
        }

        #region // Elementos de modificación.
        protected void limpiar_campos()
        {
            /*Para esta función, (Y para el resto del programa.)
             se usarán campos para limpiar y modificar los elementos correspondientes
            dentro de la interfaz de registro correspondiente, por lo cual, propiamente
            restablece el proceso para un nuevo elemento a registrar y bloquear los elementos
            que no se deban de usar hasta cumplir con las normativas impuestas por el programa
            .*/

            campo_de_id.Text = string.Empty;
            Campo_nombre_de_categoria.Text = string.Empty;

            descripcion.Text = string.Empty;

            campo_de_id.Enabled = true;
            boton_de_registrar_id.Enabled = true;
        }
        protected void funcion_de_bloqueo_para_registro()
        {
            group_para_descripcion_y_estado.Enabled = false;
        }
        protected void funcion_de_desbloqueo_para_registro()
        {
            group_para_descripcion_y_estado.Enabled = true;
        }
        
        #endregion

        #region // Campo de texto identificación
        private void campo_de_id_TextChanged(object sender, EventArgs e)
        {
            /*Para este elemento, se declara dos elementos, uno de tipo String y otro de tipo
             int, por lo cual se verificará si estos elementos son de texto o son númericos,
            por lo cual valida:
            
             1- El campo de texto esta vacío.

             2- El campo contiene letras o caracteres especiales.

             3- Si el campo contiene los elementos solicitados, en este caso,
                solo números, por lo cual desbloqueara el botón de registrar id
                y luego dará pie a verificar si el id esta repetido o no.*/

            String verificar_numeros = campo_de_id.Text;
            int verificar_numeros_en_int = 0;

            try
            {
                if (verificar_numeros != null)
                {
                    if (!(int.TryParse(verificar_numeros, out verificar_numeros_en_int)))
                    {
                     /*El código usa int.TryParse para determinar si la cadena verificar_numeros 
                     puede convertirse en un entero. Si la conversión falla, se deduce que la 
                     cadena no es un número válido (puede contener letras o caracteres especiales). 
                     En respuesta, se muestra un mensaje de error al usuario y se deshabilita el botón de 
                     registro. Este mecanismo asegura que solo números válidos sean aceptados en 
                     el campo de entrada.*/

                        mensaje.Visible = true;
                        mensaje.Text = "Solo se permiten números";

                        boton_de_registrar_id.Enabled = false;
                    }
                    else
                    {
                        mensaje.Visible = false;
                        boton_de_registrar_id.Enabled = true;
                    }

                    if (verificar_numeros == "")
                    {
                        boton_de_registrar_id.Enabled = false;
                        mensaje.Visible = true;
                        mensaje.Text = "Tiene que llenar el campo antes de continuar";
                    }
                }
            } catch (Exception ex) 
            { MessageBox.Show($"Ocurrió una excepción de tipo: {ex}"); }
        }
        #endregion

        #region // Botón de registro de id
        private void boton_de_registrar_id_Click(object sender, EventArgs e)
        {
            int numero_de_id_a_registrar = 0;

            /*En esta ocasión se verificará si los datos suministrados están en lo correcto
             o simplemente va a negar el acceso al siguiente paso de acceso de los registros 
             correspondientes.*/
            string query = String.Empty;
            try
            {   // Validación si esta en blanco el campo. 
                if (campo_de_id.Text == "" || campo_de_id.Text == null)
                {
                    mensaje.Visible = true;
                    mensaje.Text = "*Primero tiene que llenar el campo con números para continuar";

                    boton_de_registrar_id.Enabled = false;

                }
                else 
                {
                    numero_de_id_a_registrar = int.Parse(campo_de_id.Text);
                    query = "SELECT * FROM CategoriaPelicula WHERE IdCategoria = " + numero_de_id_a_registrar + "";

                    if (gestor_de_datos.busqueda_de_existencia_id(query))
                    {
                        /*En caso de que id este disponible y no se haya registrado anteriormente,
                         se procede a desbloquear las siguientes funciones para poder registrar
                         los datos correspondientes.*/

                        funcion_de_desbloqueo_para_registro();
                        mensaje.Visible = false;

                        campo_de_id.Enabled = false;
                        boton_de_registrar_id.Enabled = false;
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
            /*Para comodidad del usuario, se habilita el botón de cancelar y borrar los datos 
             suministrados en caso de que el usuario no este conforme.*/

            limpiar_campos();
            funcion_de_bloqueo_para_registro();
        }

        #endregion

        #region // Botón de registrar datos
        private void boton_de_guardar_Click(object sender, EventArgs e)
        {
            /*Para finalizar el proceso, se validará que los campos correspondientes
             estén contengan contenido y se pueda almacenar algo dentro del sistema, por
             lo tanto toma en medida las siguientes medidas para poder elavorar su debido 
             pedido.*/

            int tipo_de_excepcion = 0;
            CategoriaPelicula categoria = new CategoriaPelicula();

            try
            {
                /* Validadción de que los siguientes campos deban de ir con contenido en ellos
                   de lo cual si no es así, salta la excepción impidiendo continuar con el debido
                   proceso.
                 */

                if (campo_de_id.Text == null || campo_de_id.Text == "" || Campo_nombre_de_categoria.Text == null || Campo_nombre_de_categoria.Text == "" || descripcion.Text == null || descripcion.Text == "")
                {
                    tipo_de_excepcion = 1;

                    throw new Exception();
                }
                
                // Se declaran las variables correspondientes para extraer los datos de los campos.
                int id_de_categoria = int.Parse(campo_de_id.Text);
                String nombre_de_categoria = Campo_nombre_de_categoria.Text;
                String _descripcion = descripcion.Text;

                // Se declara las clases con sus correspondientes datos
                categoria = new CategoriaPelicula(id_de_categoria,nombre_de_categoria, _descripcion);
                
                String query = "Insert into CategoriaPelicula values(" + categoria.Id_de_categoria + ", '" + categoria.Nombre_de_la_categoria + "', '" + categoria.Descripcion + "')";
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
                    case 0:

                        MessageBox.Show("Ocurrió una excepción de tipo: " + ex);

                        break;

                    case 1:

                        MessageBox.Show("Faltan datos por llenar, por favor llenar todos los campos.");
                        tipo_de_excepcion = 0;
                        break;

                    default:

                        break;
                }
            }
        }
        #endregion
    }
    /*Estás caracteristicas se aplicarán de manera muy similar para efectos prácticos al resto
     del programa, solo que con ligueras modificaciones dentro de estás.*/

}

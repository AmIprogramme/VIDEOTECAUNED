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
    public partial class Registrar_persona : Form
    {
        private Gestor_de_registros gestor_de_datos = new Gestor_de_registros();
        public Registrar_persona()
        {
            InitializeComponent();
        }
        public void declaracion_de_variable_de_datos(Gestor_de_registros gestor) 
        {
            gestor_de_datos = gestor;
        }


        #region // Elementos de modificación.
        protected void limpiar_campos()
        {
            campo_para_id.Text = string.Empty;
           
            campo_de_nombre.Text = string.Empty;
            campo_para_primer_apellido.Text = string.Empty;
            campo_para_segundo_apellido.Text = string.Empty;
            
            campo_para_id.Enabled = true;
            btn_registrar_id.Enabled = true;

            funcion_de_bloqueo_para_registro();
        }
        protected void funcion_de_bloqueo_para_registro()
        {
            group_de_registro_de_cliente.Enabled = false;
        }
        protected void funcion_de_desbloqueo_para_registro()
        {
            group_de_registro_de_cliente.Enabled = true;
        }

        #endregion

        #region // Campo de texto identificación
        private void campo_para_id_TextChanged(object sender, EventArgs e)
        {
            String verificar_numeros = campo_para_id.Text;
            int verificar_numeros_en_int = 0;

            try
            {
                if (verificar_numeros != null)
                {
                    if (!(int.TryParse(verificar_numeros, out verificar_numeros_en_int)))
                    {
                        mensaje.Visible = true;
                        mensaje.Text = "Solo se permiten números";
                        btn_registrar_id.Enabled = false;
                    }
                    else
                    {
                        mensaje.Visible = false;
                        btn_registrar_id.Enabled = true;
                    }

                    if (verificar_numeros == "")
                    {
                        btn_registrar_id.Enabled = false;
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
        private void btn_registrar_id_Click(object sender, EventArgs e)
        {
            int numero_de_id_a_registrar = 0;
            String query = String.Empty;

            try
            {
                if (campo_para_id.Text == "" || campo_para_id.Text == null)
                {
                    mensaje.Visible = true;
                    mensaje.Text = "*Primero tiene que llenar el campo con números para continuar";

                    btn_registrar_id.Enabled = false;

                }
                else 
                {
                     numero_de_id_a_registrar = int.Parse(campo_para_id.Text);
                     query = "Select * from Persona Where Identificacion = " + numero_de_id_a_registrar + ";";

                    if (gestor_de_datos.busqueda_de_existencia_id(query))
                    {
                        funcion_de_desbloqueo_para_registro();
                        mensaje.Visible = false;

                        campo_para_id.Enabled = false;
                        btn_registrar_id.Enabled = false;
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
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            funcion_de_bloqueo_para_registro();
        }

        #endregion

        #region // Botón de registrar datos
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int tipo_de_excepcion = 0;
            Persona person = new Persona();

            try
            {
                if (campo_de_nombre.Text == "" || campo_de_nombre == null ||
                    campo_para_primer_apellido.Text == "" || campo_para_primer_apellido.Text == null ||
                    campo_para_segundo_apellido.Text == "" || campo_para_segundo_apellido.Text == null)
                {
                    tipo_de_excepcion = 1;
                    throw new Exception();
                }
                // Se declaran las variables correspondientes para extraer los datos de los campos.
                
                String identificacion = campo_para_id.Text;
                String nombre = campo_de_nombre.Text;
                String primer_apellido = campo_para_primer_apellido.Text;
                String segundo_apellido = campo_para_segundo_apellido.Text;
                DateTime nacimiento = DateTime.Parse(panel_fecha_de_nacimiento.Value.ToString("yyyy-MM-dd"));
                
                // Se declara las clases con sus correspondientes datos
                person = new Persona()
                {
                    Identificacion = identificacion,
                    Nombre = nombre,
                    Primer_apellido=primer_apellido,
                    Segundo_apellido = segundo_apellido,
                    Fecha_de_nacimiento = nacimiento
                };

                String fechaNacimiento = person.Fecha_de_nacimiento.ToString("yyyy-MM-dd");
                String query = "Insert into Persona Values ('" + person.Identificacion + "', '" + person.Nombre + "', '" + person.Primer_apellido + "', '" + person.Segundo_apellido + "', " + fechaNacimiento + ")";

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
}

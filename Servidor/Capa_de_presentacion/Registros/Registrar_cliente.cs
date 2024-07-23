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
    public partial class Registrar_cliente : Form
    {
        private Gestor_de_registros gestor_de_datos = new Gestor_de_registros();
        private static List<Persona>? personas;

        public Registrar_cliente()
        {
            InitializeComponent();
            llenar_combo_de_id_personas();
        }

        #region Llenar combox
        protected void llenar_combo_de_id_personas()
        {
            personas = gestor_de_datos.retorno_arreglo_Persona();

            foreach (Persona p in personas)
            { comboBox_de_identificaciones.Items.Add(p.Identificacion); }
        }
        #endregion

        #region Elementos de modificación.
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

        #region Campo de texto identificación
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
                     query = "Select * from Cliente where IdCliente = " + numero_de_id_a_registrar + ";";

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
        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            int tipo_de_excepcion = 0;
            Cliente costumer = new Cliente();

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
                int id = int.Parse(campo_para_id.Text);
                String identificacion = comboBox_de_identificaciones.SelectedItem.ToString()!;
                String nombre = campo_de_nombre.Text;
                String primer_apellido = campo_para_primer_apellido.Text;
                String segundo_apellido = campo_para_segundo_apellido.Text;
                DateTime nacimiento = DateTime.Parse(campo_de_nacimiento.Text);
                DateTime ingreso = DateTime.Parse(panel_fecha_de_ingreso.Value.ToString("yyyy-MM-dd"));
                bool estado = false;

                if (radioButton_activo.Checked) 
                { estado = true; }

                // Se declara las clases con sus correspondientes datos
                costumer = new Cliente()
                {
                    Id_Cliente = id,
                    Identificacion = identificacion,
                    Nombre = nombre,
                    Primer_apellido = primer_apellido,
                    Segundo_apellido = segundo_apellido,
                    Fecha_de_nacimiento = nacimiento,
                    Fecha_de_registro = ingreso,
                    Activo_ = estado
                };

                int bit = 0;
                if (costumer.Activo_) { bit = 1; }

                String query = "Insert into Cliente values (" + costumer.Id_Cliente + ", '" + costumer.Identificacion + "', "+costumer.Fecha_de_registro.ToString("yyyy-MM-dd") +", " + bit + ");";

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

        #region Selección de persona
        private void comboBox_de_identificaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_guardar.Enabled = true;
            String elemento_seleccionado = comboBox_de_identificaciones.SelectedItem.ToString()!;

            Persona? nombre_persona = personas?.FirstOrDefault(p => p.Identificacion == elemento_seleccionado);

            campo_de_nombre.Text = nombre_persona!.Nombre;
            campo_para_primer_apellido.Text = nombre_persona.Primer_apellido;
            campo_para_segundo_apellido.Text = nombre_persona.Segundo_apellido;
            campo_de_nacimiento.Text = nombre_persona.Fecha_de_nacimiento.ToString();
        }
        #endregion
    }
}

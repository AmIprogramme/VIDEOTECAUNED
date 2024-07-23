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
    public partial class Registrar_sucursal : Form
    {
        private Gestor_de_registros gestor_de_datos = new Gestor_de_registros();
        private static List<Encargado>? lista_encargado;

        public Registrar_sucursal()
        {
            InitializeComponent();
            llenar_datos_de_encargado();
        }

        #region Retorno de encargado 

        protected Encargado retorno_de_encargado_seleccionado(int id) 
        { return lista_encargado?.FirstOrDefault(p => p.Id_Encargado == id)!;}

        #endregion

        #region Otras funciones

        protected void llenar_datos_de_encargado()
        {
            lista_encargado = gestor_de_datos.retorno_arreglo_ENCARGADO();
            try
            {
                foreach (Encargado e in lista_encargado)
                {
                    comboBox_de_encargado.Items.Add(e.Id_Encargado);
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ocurrió una excepción de tipo: {ex}"); }
        }


        #endregion

        #region Elementos de modificación.
        protected void limpiar_campos()
        {
            campo_para_id.Text = string.Empty;
            campo_de_nombre.Text = string.Empty;
            campo_de_direccion.Text = string.Empty;
            campo_telefono.Text = string.Empty;

            campo_para_id.Enabled = true;
            boton_de_registro_id.Enabled = true;
        }
        protected void funcion_de_bloqueo_para_registro()
        {
            group_para_registro_de_datos.Enabled = false;
        }
        protected void funcion_de_desbloqueo_para_registro()
        {
            group_para_registro_de_datos.Enabled = true;
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

                        boton_de_registro_id.Enabled = false;
                    }
                    else
                    {
                        mensaje.Visible = false;
                        boton_de_registro_id.Enabled = true;
                    }

                    if (verificar_numeros == "")
                    {
                        boton_de_registro_id.Enabled = false;
                        mensaje.Visible = true;
                        mensaje.Text = "Tiene que llenar el campo antes de continuar";
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ocurrió una excepción de tipo: {ex}"); }
        }


        #endregion

        #region Limpiar campos.
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar_campos();
            funcion_de_bloqueo_para_registro();
        }

        #endregion

        #region Botón de registrar datos
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int tipo_de_excepcion = 0;
            Sucursal tienda = new Sucursal();

            try
            {
                if (campo_de_nombre.Text == "" || campo_de_nombre.Text == null
                    || campo_de_direccion.Text == "" || campo_de_direccion == null
                    || campo_telefono.Text == "" || campo_telefono.Text == null)
                {
                    tipo_de_excepcion = 1;

                    throw new Exception();
                }

                // Se declaran las variables correspondientes para extraer los datos de los campos.

                int id = int.Parse(campo_para_id.Text);
                String nombre = campo_de_nombre.Text;
                Encargado encargado = retorno_de_encargado_seleccionado(Convert.ToInt32(comboBox_de_encargado.SelectedItem.ToString()));

                String direccion = campo_de_direccion.Text;
                String telefono = campo_telefono.Text;
                bool estado = false;

                if (radioButton_activo.Checked)
                { estado = true; }

                // Se declara las clases con sus correspondientes datos
                tienda = new Sucursal()
                {
                    Id_de_sucursal = id,
                    Nombre = nombre,
                    _Encargado = encargado,
                    Direccion = direccion,
                    Telefono = telefono,
                    Activo_ = estado
                };

                int bit = 0;

                if (tienda.Activo_)
                {
                    bit = 1;
                }
                else { bit = 0; }

                String query = "Insert into Sucursal values (" + tienda.Id_de_sucursal + ", " + tienda._Encargado!.Id_Encargado + ", '" + tienda.Nombre + "', '" + tienda.Direccion + "', '" + tienda.Telefono + "', " + bit + ");";

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

        #region Botón de registrar id
        private void boton_de_registro_id_Click(object sender, EventArgs e)
        {
            int numero_de_id_a_registrar = 0;
            String query = String.Empty;
           try
            {
                if (campo_para_id.Text == "" || campo_para_id.Text == null)
                {
                    mensaje.Visible = true;
                    mensaje.Text = "*Primero tiene que llenar el campo con números para continuar";

                    boton_de_registro_id.Enabled = false;

                }
                else
                {
                     numero_de_id_a_registrar = int.Parse(campo_para_id.Text!);

                     query = "Select * from Sucursal where IdSucursal = " + numero_de_id_a_registrar + ";";

                    if (gestor_de_datos.busqueda_de_existencia_id(query))
                    {
                        funcion_de_desbloqueo_para_registro();
                        mensaje.Visible = false;

                        campo_para_id.Enabled = false;
                        boton_de_registro_id.Enabled = false;
                    }
                    else
                    {
                        mensaje.Visible = true;
                        mensaje.Text = "*El id ya se encuentra registrado*";
                    }
                }
                
                
           }
           catch (Exception ex)
           {
                MessageBox.Show("Ocurrió una excepción de tipo: " + ex, "Excepción: ");

           }
        }
        #endregion

        #region Selección de encargado
        private void comboBox_de_encargado_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_guardar.Enabled = true;
            int elemento_seleccionado = Convert.ToInt32(comboBox_de_encargado.SelectedItem.ToString());

            Encargado? nombre_encargado = lista_encargado?.FirstOrDefault(p => p.Id_Encargado == elemento_seleccionado);

            txt_nombre_completo_encargado.Text = nombre_encargado!.Nombre + " " + nombre_encargado.Primer_apellido +
                " " + nombre_encargado.Segundo_apellido;
        }
        #endregion
    }
}

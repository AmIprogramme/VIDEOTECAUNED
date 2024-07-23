/*
Universidad Estatal a Distancia
Cátedra de informática
Segundo cuatrimestre 2024
Nombre del estudiante: Andrés Quesada Rodríguez
Id: 117240124
Sede: Parrita 02.
Segundo proyecto a realizar.
 */


using Capa_de_entidades;
using Capa_de_Acceso_a_Datos;


namespace Servidor
{
    public partial class Registrar_peliculaxsucursal : Form
    {
        private Gestor_de_registros gestor_de_datos = new Gestor_de_registros();
        private static List<Sucursal> sucursales = null!;
        private static List<Pelicula> peliculas = null!;

        private static int cantidad_de_campo_contador = 0;

        public Registrar_peliculaxsucursal()
        {
            InitializeComponent();
            llenar_datos_de_sucursal();
        }

        #region // Funciones para inicializar datos.
        protected void llenar_datos_de_sucursal()
        {
            sucursales = gestor_de_datos.retorno_arreglo_SUCURSAL();
            try
            {
                foreach (Sucursal s in sucursales)
                { comboBox_de_sucursal.Items.Add(s.Nombre); }
            }
            catch (Exception e)
            { MessageBox.Show($"Ocurrió una excepción de tipo: {e}"); }
        }

        protected void llenar_tabla()
        {
            peliculas = gestor_de_datos.retorno_arreglo_PELICULAS();
            try
            {
                foreach (Pelicula p in peliculas)
                {
                    tabla.Rows.Add(p.Id_de_pelicula, p.Titulo, p.Categoria_pelicula!.Id_de_categoria, p.Categoria_pelicula.Nombre_de_la_categoria,
                        p.Ano_de_lanzamiento, p.Idioma);
                }
            }
            catch (Exception e)
            { MessageBox.Show($"Ocurrió una excepción de tipo: {e}"); }
        }

        private void comboBox_de_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabla.Rows.Count == 0)
            {
                tabla.Rows.Clear();
                llenar_tabla();
            }

            String nombre_sucursal = comboBox_de_sucursal.SelectedItem.ToString()!;

            Sucursal? filtro = sucursales.FirstOrDefault(p => p.Nombre == nombre_sucursal);

            campo_de_id_sucursal.Text = filtro!.Id_de_sucursal.ToString();
            campo_de_encargado.Text = filtro!._Encargado!.Nombre + " " + filtro!._Encargado!.Primer_apellido + " " + filtro!._Encargado!.Segundo_apellido;
            campo_de_direccion.Text = filtro.Direccion;
        }
        #endregion

        #region // Función para verificar duplicado de Películas por sucursal.

        protected bool verificar_duplicado_pelisXsucursal(List<PeliculaxSucursal> objeto_verificador)
        {
            List<PeliculaxSucursal> lista_original = new List<PeliculaxSucursal>();

            try
            {
                if (gestor_de_datos.retorno_lista_PELICULA_POR_SUCURSAL() != null)
                {
                    lista_original = gestor_de_datos.retorno_lista_PELICULA_POR_SUCURSAL();
                }
                else { return true; }


                foreach (PeliculaxSucursal pxs1 in objeto_verificador)
                {
                    bool Existencia_de_duplicados = lista_original.Any(p => p.Sucursal!.Id_de_sucursal == pxs1.Sucursal!.Id_de_sucursal
                    && p.Filmes!.Id_de_pelicula == pxs1.Filmes!.Id_de_pelicula);

                    if (Existencia_de_duplicados)
                    {
                        MessageBox.Show($"La sucursal {pxs1.Sucursal!.Nombre} ya tiene la película: {pxs1.Filmes!.Titulo}." +
                                 $"\nPor favor corrija el siguiente apartado para poder registrarlo.");
                        return false;
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excepción de tipo: {ex}");
                return false;
            }

            return true;
        }


        #endregion


        #region // Botón de guardar
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Sucursal la_sucursal = new Sucursal();
            Pelicula peliculas_seleccionadas = new Pelicula();
            List<PeliculaxSucursal> datos_de_PxS = new List<PeliculaxSucursal>();

            int tipo_de_excepcion = 0;

            try
            {
                // Verificar que se haya seleccionado una sucursal
                if (comboBox_de_sucursal.SelectedIndex == -1)
                {
                    tipo_de_excepcion = 1;
                    throw new Exception();
                }

                // Variables de recuperación para sucursal
                int id_de_sucursal = Convert.ToInt32(campo_de_id_sucursal.Text);
                la_sucursal = sucursales.FirstOrDefault(p => p.Id_de_sucursal == id_de_sucursal)!;

                // Verificar que los elementos de cantidad coincidan con los de los seleccionados.
                int elementos_escogidos = 0;
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    if (tabla.Rows[i].Cells[6].EditedFormattedValue != null)
                    {
                        bool es_true = (bool)tabla.Rows[i].Cells[6].EditedFormattedValue;
                        if (es_true)
                        {
                            elementos_escogidos++;
                        }
                    }
                }

                if (elementos_escogidos != cantidad_de_campo_contador)
                {
                    tipo_de_excepcion = 3;
                    throw new Exception();
                }

                // Llenamos todo con los elementos que son de las películas.
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    if (tabla.Rows[i].Cells[6].EditedFormattedValue != null)
                    {
                        bool evaluardo_de_cheked = (bool)tabla.Rows[i].Cells[6].EditedFormattedValue;
                        if (evaluardo_de_cheked)
                        {
                            Pelicula filmes = peliculas.FirstOrDefault(p => p.Id_de_pelicula == Convert.ToInt32(tabla.Rows[i].Cells[0].Value.ToString()))!;
                            PeliculaxSucursal llenar = new PeliculaxSucursal(la_sucursal, filmes, elementos_escogidos);
                            datos_de_PxS.Add(llenar);
                        }
                    }
                }

                // Ahora bien, pasamos a validar los elementos para que no allá repetidos.
                if (verificar_duplicado_pelisXsucursal(datos_de_PxS))
                {
                    gestor_de_datos.Registrar_PeliculaxSucursal(datos_de_PxS);

                    MessageBox.Show("Sus datos fueron guardados con satisfacción.");
                    campo_de_cantidad_de_inventario.Text = "0";
                    cantidad_de_campo_contador = 0;
                }
            }
            catch (Exception ex)
            {
                switch (tipo_de_excepcion)
                {
                    case 0:
                        MessageBox.Show("Ocurrió una excepción de tipo: " + ex);
                        break;
                    case 1:
                        MessageBox.Show("Primero tiene que llenar los datos de la sucursal antes de guardar datos.");
                        break;
                    case 2:
                        MessageBox.Show("No puede guardar los siguientes datos sin antes seleccionar al menos un dato.");
                        break;
                    case 3:
                        MessageBox.Show("Tiene que escoger la misma cantidad de elementos como definió en el inventario.");
                        break;
                    default:
                        MessageBox.Show("Este enunciado no corresponde a ningún campo.");
                        break;
                }
            }

        } // Fin del botón de guardado.
        #endregion

        #region Elementos de modificación de filmes y su cantidad de inventario.
        private void btn_escoger_cantidad_Click(object sender, EventArgs e)
        {
            cantidad_de_campo_contador++;
            campo_de_cantidad_de_inventario.Text = cantidad_de_campo_contador.ToString();

        }

        private void btn_corregir_Click(object sender, EventArgs e)
        {
            if (cantidad_de_campo_contador > 0)
            {
                cantidad_de_campo_contador--;
                campo_de_cantidad_de_inventario.Text = cantidad_de_campo_contador.ToString();
            }
        }

        private void campo_de_cantidad_de_inventario_TextChanged(object sender, EventArgs e)
        {
            if (cantidad_de_campo_contador == 0 && campo_de_cantidad_de_inventario.Text == "0")
            {
                tabla.ReadOnly = true;
                cantidad_de_campo_contador = 0;
            }
            else { tabla.ReadOnly = false; }
        }

        private void btn_restablecer_marcador_Click(object sender, EventArgs e)
        {
            cantidad_de_campo_contador = 0;
            campo_de_cantidad_de_inventario.Text = cantidad_de_campo_contador.ToString();
        }
        #endregion

        #region Gestión de tabla sobre casillas sin llenar.
        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool banderazo = false;

            // Verificar que se haya seleccionado al menos una película

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i].Cells[6].EditedFormattedValue != null)
                {
                    bool es_true = (bool)tabla.Rows[i].Cells[6].EditedFormattedValue;
                    if (es_true)
                    {
                        banderazo = true;
                        break;
                    }
                }
            }

            //MessageBox.Show($"Cantidad de películas seleccionadas: {elementos_escogidos}");

            if (banderazo)
            { btn_Guardar.Enabled = true; }
            else
            { btn_Guardar.Enabled = false; }

        }
        #endregion
    }
}

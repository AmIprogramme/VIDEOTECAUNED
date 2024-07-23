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
    public partial class Consultar_pelicula : Form
    {
        private Gestor_de_registros registros = new Gestor_de_registros();
        public Consultar_pelicula()
        {
            InitializeComponent();
            llenar_tabla();
        }

        
        protected void llenar_tabla()
        {
            List<Pelicula> lista = registros.retorno_arreglo_PELICULAS();
            try
            {
                foreach (Pelicula e in lista)
                {
                
                    tabla_de_registros.Rows.Add(e.Id_de_pelicula,e.Titulo , e.Categoria_pelicula!.Nombre_de_la_categoria,e.Ano_de_lanzamiento, e.Idioma);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ejecuto una excepción de tipo: " + ex);

            }
        }
    }
}

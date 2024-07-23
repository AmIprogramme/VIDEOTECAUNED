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
    public partial class Consultar_categoria : Form
    {
        private Gestor_de_registros registros = new Gestor_de_registros();
        public Consultar_categoria()
        {
            InitializeComponent();
            llenar_tabla();
        }

        public void llenar_tabla() 
        {
            try
            {
                List<CategoriaPelicula> listas = registros.retorno_lista_CATEGORIA_PELICULAS();

                foreach (CategoriaPelicula e in listas) 
                {
                    tabla_de_categoria.Rows.Add(e.Id_de_categoria, e.Nombre_de_la_categoria, e.Descripcion);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ejecuto una excepción de tipo: " + ex);

            }
        }


    }
}

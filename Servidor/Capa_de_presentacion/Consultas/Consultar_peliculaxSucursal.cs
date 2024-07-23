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
    public partial class Consultar_peliculaxSucursal : Form
    {
        private Gestor_de_registros gestor_de_datos = new Gestor_de_registros();


        public Consultar_peliculaxSucursal()
        {
            InitializeComponent();
            llenar_datos_de_tabla();
        }

        #region Llenado de datos de sucursales.
        protected void llenar_datos_de_tabla()
        {

            List<PeliculaxSucursal> datos = gestor_de_datos.retorno_lista_PELICULA_POR_SUCURSAL();
            try
            {
                foreach (PeliculaxSucursal ps in datos)
                {
                    tabla.Rows.Add(ps.Sucursal!.Id_de_sucursal, ps.Sucursal.Nombre,
                        ps.Sucursal._Encargado!.Nombre +" " + ps.Sucursal._Encargado.Primer_apellido+ " "+
                         ps.Sucursal._Encargado.Segundo_apellido, ps.Filmes!.Id_de_pelicula,
                         ps.Filmes.Titulo, ps.Filmes.Categoria_pelicula.Id_de_categoria,
                         ps.Filmes.Categoria_pelicula.Nombre_de_la_categoria, ps.Filmes.Ano_de_lanzamiento,
                         ps.Filmes.Idioma);   
                }

            }
            catch (Exception ex)
            { MessageBox.Show($"Ocurrió una excepción de tipo: {ex}"); }
        }

        #endregion

    }
}

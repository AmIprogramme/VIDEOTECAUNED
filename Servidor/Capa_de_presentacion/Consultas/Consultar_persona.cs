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
    public partial class Consultar_persona : Form
    {
        private Gestor_de_registros registros = new Gestor_de_registros();
        public Consultar_persona()
        {
            InitializeComponent();
            llenar_tabla();
        }
        

        protected void llenar_tabla()
        {
            List<Persona> lista = registros.retorno_arreglo_Persona();
            try
            {
                foreach (Persona e in lista) 
                {
                    tabla_de_registros.Rows.Add(e.Identificacion, e.Nombre, e.Primer_apellido, e.Segundo_apellido, e.Fecha_de_nacimiento.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ejecuto una excepción de tipo: " + ex);

            }
        }
    }
}

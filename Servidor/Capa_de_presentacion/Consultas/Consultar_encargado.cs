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
    public partial class Consultar_encargado : Form
    {
        private Gestor_de_registros registros = new Gestor_de_registros();
        public Consultar_encargado()
        {
            InitializeComponent();
            llenar_tabla();
        }
        

        protected void llenar_tabla()
        {
            List<Encargado> lista = registros.retorno_arreglo_ENCARGADO();

            try
            {
                foreach (Encargado en in lista)
                { 
                    tabla_de_registros.Rows.Add(en.Id_Encargado, en.Identificacion, en.Nombre,
                        en.Primer_apellido, en.Segundo_apellido, en.Fecha_de_nacimiento, en.Fecha_de_ingreso);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ejecuto una excepción de tipo: " + ex);

            }
        }
    }
}

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
    public partial class Consultar_cliente : Form
    {
        private Gestor_de_registros registros = new Gestor_de_registros();
        public Consultar_cliente()
        {
            InitializeComponent();
            llenar_tabla();
        }

        public void llenar_tabla()
        {
            List<Cliente> lista = registros.retorno_arreglo_CLIENTE();

            try
            {
                String activo = String.Empty;
                foreach (Cliente c in lista)
                {
                    if (c.Activo_)
                    { activo = "Si"; }
                    else { activo = "No"; }

                    tabla_de_contenidos.Rows.Add(c.Id_Cliente, c.Identificacion, c.Nombre+" "+
                        c.Primer_apellido+" "+c.Segundo_apellido, 
                        c.Fecha_de_nacimiento, c.Fecha_de_registro, activo);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ejecuto una excepción de tipo: " + ex);

            }
        }

    }
}

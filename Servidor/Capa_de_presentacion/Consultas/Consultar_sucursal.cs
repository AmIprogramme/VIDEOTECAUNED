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
    public partial class Consultar_sucursal : Form
    {
        private Gestor_de_registros registros = new Gestor_de_registros();
        public Consultar_sucursal()
        {
            InitializeComponent();
            llenar_tabla();
        }

        protected void llenar_tabla()
        {
            List<Sucursal> lista = registros.retorno_arreglo_SUCURSAL();
            try
            {
                String estado = string.Empty;



                foreach (Sucursal s in lista) 
                {
                    if (s.Activo_)
                    {
                        estado = "Si";
                    }
                    else 
                    { estado = "No"; }

                    tabla_de_contenidos.Rows.Add(s.Id_de_sucursal, s.Nombre, s._Encargado?.Nombre+" " 
                        +s._Encargado?.Primer_apellido+" "+s._Encargado?.Segundo_apellido, 
                        s.Direccion, s.Telefono, estado);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ejecuto una excepción de tipo: " + ex);

            }
        }
    }
}

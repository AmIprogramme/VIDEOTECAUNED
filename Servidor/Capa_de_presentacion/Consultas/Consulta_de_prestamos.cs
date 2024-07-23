using Capa_de_Acceso_a_Datos;
using Capa_de_entidades;

namespace Servidor.Capa_de_presentacion.Consultas
{
    public partial class Consulta_de_prestamos : Form
    {
        private Gestor_de_registros registros = new Gestor_de_registros();
        private static List<Cliente>? lista_clientes;
        private static List<Prestamo>? lista_prestamos;

        public Consulta_de_prestamos()
        {
            InitializeComponent();
            llenar_combo();
        }

        protected void llenar_combo()
        {
            lista_clientes = registros.retorno_arreglo_CLIENTE();
            foreach (Cliente p in lista_clientes)
            {
                comboBox_de_identificaciones.Items.Add(p.Id_Cliente);
            }
        }

        private void comboBox_de_identificaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
            int elemento = Convert.ToInt32(comboBox_de_identificaciones.SelectedItem.ToString());
            Cliente cl = lista_clientes!.FirstOrDefault(p => p.Id_Cliente == elemento)!;
            campo_de_nombre.Text = cl.Nombre + " " + cl.Primer_apellido +" "+ cl.Segundo_apellido;

            if (registros.retorno_lista_de_prestamo_por_id(elemento) != null)
            {
                lista_prestamos = registros.retorno_lista_de_prestamo_por_id(elemento);
                foreach (Prestamo p in lista_prestamos)
                {
                    if (p == null)
                    { break; }
                    String pendiente = "No";

                    if (p.Pendiente_de_devolucion)
                    {
                        pendiente = "Si";
                    }
                    tabla.Rows.Add(p.Id_de_prestamos, p._Cliente.Id_Cliente, p._Sucursal.Id_de_sucursal, p._Pelicula.Id_de_pelicula,
                        p.Fecha_de_prestamo, pendiente);
                }
            }
            else 
            {
                MessageBox.Show("No se encontraron registros.");
            }
        }
    }
}

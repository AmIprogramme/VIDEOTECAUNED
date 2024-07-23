/*
Universidad Estatal a Distancia
Cátedra de informática
Primer cuatrimestre 2024
Nombre del estudiante: Andrés Quesada Rodríguez
Id: 117240124
Sede: Alajuela.
Segundo proyecto a realizar.
 */

using System.Windows.Forms;
using Usuario.Interfaces;


namespace Usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu_de_ingreso());
        }
    }
}

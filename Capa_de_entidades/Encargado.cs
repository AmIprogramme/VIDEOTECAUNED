
namespace Capa_de_entidades
{
    public class Encargado:Persona
    {

        private int id_Encargado = 0;
        private DateTime fecha_de_ingreso = DateTime.Now;

        public Encargado()
        {
        }

        public Encargado(int id_Encargado, string identificacion, string nombre, string primer_apellido, string segundo_apellido, DateTime fecha_de_nacimiento, DateTime fecha_de_ingreso):base(identificacion,nombre, primer_apellido, segundo_apellido, fecha_de_nacimiento )
        {
            this.id_Encargado = id_Encargado;
            this.fecha_de_ingreso = fecha_de_ingreso;
        }

       public int Id_Encargado { get => id_Encargado; set => id_Encargado = value; }
       public DateTime Fecha_de_ingreso { get => fecha_de_ingreso; set => fecha_de_ingreso = value; }
    }
}

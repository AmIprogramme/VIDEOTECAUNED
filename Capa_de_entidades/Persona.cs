
namespace Capa_de_entidades
{
    public class Persona
    {
        private String identificacion = " ";
        private String nombre = " ";
        private String primer_apellido = " ";
        private String segundo_apellido = " ";
        private DateTime fecha_de_nacimiento = DateTime.Now;

        public Persona()
        {

        }

        public Persona(string identificacion, string nombre, string primer_apellido, string segundo_apellido, DateTime fecha_de_nacimiento)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.primer_apellido = primer_apellido;
            this.segundo_apellido = segundo_apellido;
            this.fecha_de_nacimiento = fecha_de_nacimiento;
        }

        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Primer_apellido { get => primer_apellido; set => primer_apellido = value; }
        public string Segundo_apellido { get => segundo_apellido; set => segundo_apellido = value; }
        public DateTime Fecha_de_nacimiento { get => fecha_de_nacimiento; set => fecha_de_nacimiento = value; }
    }
}

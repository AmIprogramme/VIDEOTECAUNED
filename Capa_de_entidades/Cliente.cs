
namespace Capa_de_entidades 
{ 
    public class Cliente: Persona
    {

        private int id_Cliente = 0;
        private DateTime fecha_de_registro = DateTime.Now;
        private bool _activo_ = false;

        public Cliente()
        {
        }

        public Cliente(int id_Cliente, string identificacion, string nombre, string primer_apellido, string segundo_apellido, DateTime fecha_de_nacimiento, DateTime fecha_de_registro, bool activo_)
        :base(identificacion, nombre, primer_apellido, segundo_apellido, fecha_de_nacimiento)
        {
            this.Id_Cliente = id_Cliente;
            
            this.Fecha_de_registro = fecha_de_registro;
            Activo_ = activo_;
        }

        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public DateTime Fecha_de_registro { get => fecha_de_registro; set => fecha_de_registro = value; }
        public bool Activo_ { get => _activo_; set => _activo_ = value; }
    }
}

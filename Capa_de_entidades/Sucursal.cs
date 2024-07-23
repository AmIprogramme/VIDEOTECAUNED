
namespace Capa_de_entidades
{
    public class Sucursal
    {
        private int id_de_sucursal = 0;
        private String nombre = " ";
        private Encargado? encargado = null;
        private String direccion = " ";
        private String telefono = " ";
        private bool _activo_ = false;

        public Sucursal() 
        {}
        public Sucursal(int id_de_sucursal, string nombre, Encargado encargado, string direccion, string telefono, bool activo_)
        {
            this.id_de_sucursal = id_de_sucursal;
            this.nombre = nombre;
            this.encargado = encargado;
            this.direccion = direccion;
            this.telefono = telefono;
            _activo_ = activo_;
        }

        public int Id_de_sucursal { get => id_de_sucursal; set => id_de_sucursal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Encargado? _Encargado { get => encargado; set => encargado = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public bool Activo_ { get => _activo_; set => _activo_ = value; }
    }
}

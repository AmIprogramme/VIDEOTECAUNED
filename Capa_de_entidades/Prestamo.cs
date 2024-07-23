
namespace Capa_de_entidades
{
    public class Prestamo
    {
        private int id_de_prestamos = 0;
        private Cliente cliente = null!;
        private Sucursal sucursal = null!;
        private Pelicula pelicula = null!;
        private DateTime fecha_de_prestamo = DateTime.Now;
        private bool pendiente_de_devolucion = false;

        public Prestamo()
        {
        }

        public Prestamo(int id_de_prestamos, Cliente id_de_cliente, Sucursal id_de_sucursal, Pelicula id_de_pelicula, DateTime fecha_de_prestamo, bool pendiente_de_devolucion)
        {
            this.Id_de_prestamos = id_de_prestamos;
            this.cliente = id_de_cliente;
            this.sucursal = id_de_sucursal;
            this.pelicula = id_de_pelicula;
            this.Fecha_de_prestamo = fecha_de_prestamo;
            this.Pendiente_de_devolucion = pendiente_de_devolucion;
        }

        public int Id_de_prestamos { get => id_de_prestamos; set => id_de_prestamos = value; }
        public Cliente _Cliente { get => cliente; set => cliente = value; }
        public Sucursal _Sucursal { get => sucursal; set => sucursal = value; }
        public Pelicula _Pelicula { get => pelicula; set => pelicula = value; }
        public DateTime Fecha_de_prestamo { get => fecha_de_prestamo; set => fecha_de_prestamo = value; }
        public bool Pendiente_de_devolucion { get => pendiente_de_devolucion; set => pendiente_de_devolucion = value; }
    }
}

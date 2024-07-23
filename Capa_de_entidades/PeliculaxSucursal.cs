
namespace Capa_de_entidades
{
    public class PeliculaxSucursal
    {
        
        private Sucursal? sucursal = null;
        private Pelicula? filmes = null;
        private int cantidad = 0;

        public PeliculaxSucursal()
        {
        }

        public PeliculaxSucursal(Sucursal sucursal, Pelicula filmes, int cantidad)
        {
            this.sucursal = sucursal;
            this.filmes = filmes;
            this.cantidad = cantidad;
        }

        public Sucursal? Sucursal { get => sucursal; set => sucursal = value; }
        public Pelicula? Filmes { get => filmes; set => filmes = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}

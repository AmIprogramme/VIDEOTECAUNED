

namespace Capa_de_entidades
{
    
    public class CategoriaPelicula
    {
        private int id_de_categoria = 0;
        private String nombre_de_la_categoria = "";
        private String descripcion = "";

        public CategoriaPelicula()
        {
        }

        public CategoriaPelicula(int id_de_categoria, string nombre_de_la_categoria, string descripcion)
        {
            this.id_de_categoria = id_de_categoria;
            this.nombre_de_la_categoria = nombre_de_la_categoria;
            this.descripcion = descripcion;
        }

        public int Id_de_categoria { get => id_de_categoria; set => id_de_categoria = value; }
        public string Nombre_de_la_categoria { get => nombre_de_la_categoria; set => nombre_de_la_categoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}

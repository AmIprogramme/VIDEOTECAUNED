

namespace Capa_de_entidades
{
    public class Pelicula
    {
        private int id_de_pelicula = 0;
        private String titulo = " ";
        private CategoriaPelicula? categoria_pelicula  = null;
        private int ano_de_lanzamiento = 0;
        private String? idioma = "";

        public Pelicula()
        {
        }

        public Pelicula(int id_de_pelicula, string titulo, CategoriaPelicula categoria_película, int ano_de_lanzamiento, string idioma)
        {
            this.id_de_pelicula = id_de_pelicula;
            this.titulo = titulo;
            this.categoria_pelicula = categoria_película;
            this.ano_de_lanzamiento = ano_de_lanzamiento;
            this.idioma = idioma;
        }

        public int Id_de_pelicula { get => id_de_pelicula; set => id_de_pelicula = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public CategoriaPelicula? Categoria_pelicula { get => categoria_pelicula; set => categoria_pelicula = value; }
        public int Ano_de_lanzamiento { get => ano_de_lanzamiento; set => ano_de_lanzamiento = value; }
        public string? Idioma { get => idioma; set => idioma = value; }

       
    }
}

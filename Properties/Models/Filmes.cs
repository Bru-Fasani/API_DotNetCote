namespace FilmesApi.Models
{
    public class Filme
    {
        public int ID { get; set; }
        public string? Titulo { get; set; }
        public string? Genero { get; set; }
        public int Duracao { get; set; }
    }
}
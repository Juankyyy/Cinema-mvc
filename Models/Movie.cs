namespace Cinema.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image  { get; set; }
        public string Sinopsis  { get; set; }
        public string Rating  { get; set; }
        public string Duration  { get; set; }
        public string Category  { get; set; }
        public int ReleaseDate  { get; set; }
    }
}
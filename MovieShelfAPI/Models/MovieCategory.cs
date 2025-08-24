namespace MovieShelfAPI.Models
{
    public class MovieCategory
    {
        public int MovieId { get; set; }
        public int CategoryId { get; set; }
        public Movie Movie { get; set; } = null!;
        public Category Category { get; set; } = null!;
    }
}

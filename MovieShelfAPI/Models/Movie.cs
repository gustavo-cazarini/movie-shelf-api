using System.ComponentModel.DataAnnotations;

namespace MovieShelfAPI.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public string Synopsis { get; set; }
        public List<Category> Categories { get; } = [];
    }
}

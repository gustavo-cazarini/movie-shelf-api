using System.ComponentModel.DataAnnotations;

namespace MovieShelfAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }
        public List<Movie> Movies { get; } = [];
        public List<MovieCategory> MovieCategories { get; } = [];
    }
}

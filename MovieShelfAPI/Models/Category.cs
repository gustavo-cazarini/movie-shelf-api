using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MovieShelfAPI.Models
{
    public class Category
    {
        ///<summary>
        /// Category unique identifier
        /// </summary>
        [Key]
        public int Id { get; set; }

        ///<summary>
        /// Category name, like 'Horror', 'Adventure', etc.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<Movie> Movies { get; } = [];

        [JsonIgnore]
        public List<MovieCategory> MovieCategories { get; } = [];
    }
}

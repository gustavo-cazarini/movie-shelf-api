using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MovieShelfAPI.Models
{
    [Table("Movie")]
    public class Movie
    {
        ///<summary>
        /// Movie unique identifier
        /// </summary>
        [Key]
        public int Id { get; set; }

        ///<summary>
        /// Movie name
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }

        ///<summary>
        /// Movie release date
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        ///<summary>
        /// Name of the director of the movie
        /// </summary>
        public string? Director { get; set; }

        ///<summary>
        /// Cast of the movie
        /// </summary>
        public string? Cast { get; set; }

        ///<summary>
        /// Movie synopsis, describing it
        /// </summary>
        public string? Synopsis { get; set; }

        public List<Category> Categories { get; } = [];

        [JsonIgnore]
        public List<MovieCategory> MovieCategories { get; } = [];
    }
}

using MovieShelfAPI.Models;

namespace MovieShelfAPI.Repositories
{
    public interface IMovieRepository
    {
        public IEnumerable<Movie> GetAll();

        public Movie? GetById(int id);
    }
}

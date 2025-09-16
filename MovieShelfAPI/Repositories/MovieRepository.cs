using MovieShelfAPI.Context;
using MovieShelfAPI.Models;

namespace MovieShelfAPI.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context) { _context = context; }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movies.AsEnumerable();
        }

        public Movie? GetById(int id)
        {
            var movie = _context.Movies.Where(movie => movie.Id == id).FirstOrDefault();

            return movie;
        }
    }
}

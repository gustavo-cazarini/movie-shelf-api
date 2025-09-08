using Microsoft.AspNetCore.Mvc;
using MovieShelfAPI.Models;
using MovieShelfAPI.Repositories;

namespace MovieShelfAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        ///<summary>
        /// Returns all the movies registered in the application
        /// </summary>
        [HttpGet]
        public IEnumerable<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }
    }
}

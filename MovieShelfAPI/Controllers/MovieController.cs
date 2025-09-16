using Microsoft.AspNetCore.Mvc;
using MovieShelfAPI.Models;
using MovieShelfAPI.Repositories;

namespace MovieShelfAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
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

        ///<summary>
        /// Returns a movie by its unique identifier
        /// </summary>
        /// <param name="id">movie unique identifier</param>
        [HttpGet]
        public Movie? GetById(int id)
        {
            return _movieRepository.GetById(id);
        }
    }
}

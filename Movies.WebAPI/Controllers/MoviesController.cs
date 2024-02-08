using Microsoft.AspNetCore.Mvc;
using Movies.WebAPI.Data;

namespace Movies.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesAPIDbContext _context;

        public MoviesController(MoviesAPIDbContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {
            var movie = _context.Movies
                .FirstOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        [HttpGet("genre/{genre}")]
        public IActionResult GetMoviesByGenre(string genre)
        {
            var movies = _context.Movies
                .Where(m => m.MovieGenres.Any(mg => mg.Genre.Name.ToLower() == genre.ToLower()))
                .ToList();

            return Ok(movies);
        }
    }
}

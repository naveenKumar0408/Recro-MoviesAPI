using Microsoft.AspNetCore.Mvc;
using Movies.WebAPI.Data;

namespace Movies.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActorsController : ControllerBase
    {
        private readonly MoviesAPIDbContext _context;

        public ActorsController(MoviesAPIDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetActor(int id)
        {
            var actor = _context.Actors
                .FirstOrDefault(a => a.Id == id);

            if (actor == null)
            {
                return NotFound();
            }

            return Ok(actor);
        }
    }
}

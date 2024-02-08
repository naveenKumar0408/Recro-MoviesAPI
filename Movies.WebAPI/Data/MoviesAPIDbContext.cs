using Microsoft.EntityFrameworkCore;
using Movies.WebAPI.Models;

namespace Movies.WebAPI.Data
{
    public class MoviesAPIDbContext : DbContext
    {
        public MoviesAPIDbContext(DbContextOptions<MoviesAPIDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
    }
}

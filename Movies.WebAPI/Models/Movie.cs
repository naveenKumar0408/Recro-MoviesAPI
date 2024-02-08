namespace Movies.WebAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}

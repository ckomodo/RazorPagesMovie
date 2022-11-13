using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RazorPagesMovieContext context)
        {

            // Look for any movie.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            var movies = new Movie[]
            {
                new Movie {}
            };


        }

    }
}   

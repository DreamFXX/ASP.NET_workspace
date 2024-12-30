using Microsoft.EntityFrameworkCore;
using RazorPagesMovies.Data;
using RazorPagesMovies.Models;

namespace RazorPagesMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new AppDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<AppDbContext>>()))
        {
            if (context == null || context.Movie == null)
            {
                throw new ArgumentNullException("Null AppDbContext");
            }

            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "Vlk z Wolf Street",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Comedy",
                    Price = 7.99M,
                    Rating = "Nice!"
                },

                new Movie
                {
                    Title = "Ghostbusters",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Action",
                    Price = 8.99M,
                    Rating = "Awfull"
                },

                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Drama",
                    Price = 9.99M,
                    Rating = "Best!"
                },

                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "bet."
                }
            );
            context.SaveChanges();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;


namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                //if (context.Movie.Any() && context.Genre.Any())
                //{
                //    return;   // DB has been seeded
                //}

                //context.Movie.AddRange(
                //    new Movie
                //    {
                //        Title = "When Harry Met Steve",
                //        ReleaseDate = DateTime.Parse("1989-2-12"),
                //        Genre = "Romantic Comedy",
                //        Price = 7.99M,
                //        Rating = Rating.Slightly_Crap,
                //        MovieGenreId = 1,
                //        MovieGenre = 
                //    },

                //    new Movie
                //    {
                //        Title = "Ghostbusters ",
                //        ReleaseDate = DateTime.Parse("1984-3-13"),
                //        Genre = "Comedy",
                //        Price = 8.99M,
                //        Rating = Rating.Okish,
                //        MovieGenreId = 1
                //    },

                //    new Movie
                //    {
                //        Title = "Ghostbusters 2",
                //        ReleaseDate = DateTime.Parse("1986-2-23"),
                //        Genre = "Comedy",
                //        Price = 9.99M,
                //        Rating = Rating.Average,
                //        MovieGenreId = 2
                //    },

                //    new Movie
                //    {
                //        Title = "Rio Bravo",
                //        ReleaseDate = DateTime.Parse("1959-4-15"),
                //        Genre = "Western",
                //        Price = 3.99M,
                //        Rating = Rating.Average,
                //        MovieGenreId = 4
                //    }
                //);

                //context.Genre.AddRange(
                //    new Genre
                //    {
                //        Id = 1,
                //        MovieGenre = "Comedy",
                //        Movies = new List { }
                //    },

                //    new Genre
                //    {
                //        Id = 2,
                //        MovieGenre = "UUUUUUU"
                //    },

                //    new Genre
                //    {
                //        Id = 3,
                //        MovieGenre = "Horror"
                //     },

                //    new Genre
                //    {
                //        Id = 4,
                //        MovieGenre = "Politics"
                //    }
                //);
                //context.SaveChanges();

                context.SaveChanges();
            }
        }
    }
}
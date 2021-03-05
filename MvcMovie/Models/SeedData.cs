using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2013-10-09"),
                        Genre = MovieGenres.Action,
                        Price = 2.10M,
                        Rating = "PG-13",
                        ImagePath = "\\images\\The_Saratov_Approach.jpg"
                    },

                    new Movie
                    {
                        Title = "Once I Was a Beehive ",
                        ReleaseDate = DateTime.Parse("2015-08-14"),
                        Genre = MovieGenres.Comedy,
                        Price = 0.73M,
                        Rating = "PG",
                        ImagePath = "\\images\\Once_I_Was_a_Beehive.jpg"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-06-03"),
                        Genre = MovieGenres.Adventure,
                        Price = 1.99M,
                        Rating = "PG",
                        ImagePath = "\\images\\17miracles.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = MovieGenres.Documentary,
                        Price = 6.05M,
                        Rating = "PG",
                        ImagePath = "\\images\\Meet_the_Mormons.jpg"
                    }
                ); 
                context.SaveChanges();
            }
        }
    }
}

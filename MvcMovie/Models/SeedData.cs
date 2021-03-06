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
                        Price = 17.99M,
                        Rating = "PG-13",
                        ImagePath = "The_Saratov_Approach.jpg"
                    },

                    new Movie
                    {
                        Title = "Once I Was a Beehive ",
                        ReleaseDate = DateTime.Parse("2015-08-14"),
                        Genre = MovieGenres.Comedy,
                        Price = 9.99M,
                        Rating = "PG",
                        ImagePath = "Once_I_Was_a_Beehive.jpg"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("2011-06-03"),
                        Genre = MovieGenres.Adventure,
                        Price = 9.99M,
                        Rating = "PG",
                        ImagePath = "17miracles.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-10-10"),
                        Genre = MovieGenres.Documentary,
                        Price = 5.99M,
                        Rating = "PG",
                        ImagePath = "Meet_the_Mormons.jpg"
                    },
                    new Movie
                    {
                        Title = "Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = MovieGenres.Drama,
                        Price = 9.99M,
                        Rating = "PG",
                        ImagePath = "Other_Side_of_Heaven.jpg"
                    },
                    new Movie
                    {
                        Title = "Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-02-20"),
                        Genre = MovieGenres.Comedy,
                        Price = 9.99M,
                        Rating = "PG",
                        ImagePath = "Best_Two_Years.jpg"
                    },
                    new Movie
                    {
                        Title = "Young Joseph 1820",
                        ReleaseDate = DateTime.Parse("2020-03-17"),
                        Genre = MovieGenres.Drama,
                        Price = 7.99M,
                        Rating = "PG",
                        ImagePath = "Young_Joseph_1820.png"
                    }
                ); 
                context.SaveChanges();
            }
        }
    }
}

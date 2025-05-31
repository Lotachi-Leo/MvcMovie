using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
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
                    Title = "Get Out",
                    ReleaseDate = DateTime.Parse("2019-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Coming to America ",
                    ReleaseDate = DateTime.Parse("1999-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Pluto",
                    ReleaseDate = DateTime.Parse("2002-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Wild Wild West",
                    ReleaseDate = DateTime.Parse("2009-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 3.99M
                },
                 new Movie
                 {
                     Title = "Heaven's Gate",
                     ReleaseDate = DateTime.Parse("2011-4-15"),
                     Genre = "Western",
                     Rating = "R",
                     Price = 3.99M
                 }, new Movie
                 {
                     Title = "Johnny Bravo",
                     ReleaseDate = DateTime.Parse("1959-4-15"),
                     Genre = "Western",
                     Rating = "R",
                     Price = 3.99M
                 },
                  new Movie
                  {
                      Title = "Pretty Woman",
                      ReleaseDate = DateTime.Parse("2001-4-06"),
                      Genre = "Western",
                      Rating = "R",
                      Price = 3.99M
                  },
                   new Movie
                   {
                       Title = "Forest Grump",
                       ReleaseDate = DateTime.Parse("2013-4-17"),
                       Genre = "Western",
                       Rating = "R",
                       Price = 3.99M
                   },
                    new Movie
                    {
                        Title = "Rico",
                        ReleaseDate = DateTime.Parse("1991-4-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M
                    }

            );
            context.SaveChanges();
        }
    }
}
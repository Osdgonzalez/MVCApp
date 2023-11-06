using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCApp.Data;
using System;
using System.Linq;

namespace MVCApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new MVCAppContext(
                                        serviceProvider.GetRequiredService<DbContextOptions<MVCAppContext>>())) {

                //Look for any movies
                if (context.Movie.Any())
                {
                    return; //db has been seeded
                }

                context.Movie.AddRange(
                    
                        new Movie
                        {
                            Title = "El señor de los anillos",
                            ReleaseDate = DateTime.Parse("1997-7-21"),
                            Genre = "Fantasia Medieval",
                            Raiting = "R",
                            Price = 90M
                        },
                        new Movie
                        {
                            Title = "Harry Potter",
                            ReleaseDate = DateTime.Parse("1997-9-21"),
                            Genre = "Fantasia",
                            Raiting = "A",
                            Price = 70M
                        },
                        new Movie
                        {
                            Title = "Ghostbuster",
                            ReleaseDate = DateTime.Parse("1987-12-01"),
                            Genre = "Fantasia",
                            Raiting = "PG-13",
                            Price = 1.8M
                        },
                        new Movie
                        {
                            Title = "Click",
                            ReleaseDate = DateTime.Parse("2000-5-30"),
                            Genre = "Comedia",
                            Raiting = "PG-13",
                            Price = 0.89M
                        }

                    );


                context.SaveChanges();
            
            }

        }

    }
}

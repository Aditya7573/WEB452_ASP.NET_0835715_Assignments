using Aditya_Tie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Aditya_Tie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TieContext(
                serviceProvider.GetRequiredService<DbContextOptions<TieContext>>()))
            {
                // Look for any ties.
                if (context.Tie.Any())
                {
                    return; // DB has been seeded
                }

                context.Tie.AddRange(
     new Tie
     {
         Id = 1,
         Design = "Classic Striped",
         ReleaseDate = DateTime.Parse("2023-10-05"),
         Material = "Silk",
         Price = 29.99M,
         IsAvailable = true,
         Rating = CustomRatingScale.Three
     },

     new Tie
     {
         Id = 2,
         Design = "Polka Dot",
         ReleaseDate = DateTime.Parse("2023-10-08"),
         Material = "Cotton",
         Price = 24.99M,
         IsAvailable = false,
         Rating = CustomRatingScale.Two

     },

     new Tie
     {
         Id = 3,
         Design = "Solid Black",
         ReleaseDate = DateTime.Parse("2023-10-10"),
         Material = "Silk",
         Price = 19.99M,
         IsAvailable = true,
         Rating = CustomRatingScale.One
     },

     new Tie
     {
         Id = 4,
         Design = "Striped Blue",
         ReleaseDate = DateTime.Parse("2023-10-15"),
         Material = "Silk",
         Price = 26.99M,
         IsAvailable = true,
         Rating = CustomRatingScale.Five
     },

     new Tie
     {
         Id = 5,
         Design = "Polka Dot Red",
         ReleaseDate = DateTime.Parse("2023-10-18"),
         Material = "Cotton",
         Price = 21.99M,
         IsAvailable = false,
         Rating = CustomRatingScale.Five
     },

     new Tie
     {
         Id = 6,
         Design = "Classic Plaid",
         ReleaseDate = DateTime.Parse("2023-10-20"),
         Material = "Silk",
         Price = 31.99M,
         IsAvailable = true,
         Rating = CustomRatingScale.Four
     },

     new Tie
     {
         Id = 7,
         Design = "Solid Navy",
         ReleaseDate = DateTime.Parse("2023-10-25"),
         Material = "Silk",
         Price = 19.99M,
         IsAvailable = true,
         Rating = CustomRatingScale.Three
     },

     new Tie
     {
         Id = 8,
         Design = "Striped Green",
         ReleaseDate = DateTime.Parse("2023-10-28"),
         Material = "Cotton",
         Price = 26.99M,
         IsAvailable = true,
         Rating = CustomRatingScale.Two
     },

     new Tie
     {
         Id = 9,
         Design = "Polka Dot Yellow",
         ReleaseDate = DateTime.Parse("2023-11-01"),
         Material = "Cotton",
         Price = 21.99M,
         IsAvailable = false,
         Rating = CustomRatingScale.Three
     },

     new Tie
     {
         Id = 10,
         Design = "Classic Paisley",
         ReleaseDate = DateTime.Parse("2023-11-05"),
         Material = "Silk",
         Price = 29.99M,
         IsAvailable = true,
         Rating = CustomRatingScale.Three
     }
 );

                context.SaveChanges();
            }
        }
    }
}

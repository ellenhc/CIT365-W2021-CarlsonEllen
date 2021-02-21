using System;
using System.Linq;
using MyScriptureJournal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "Moses",
                        Chapter = "1",
                        Verse = "39",
                        DateAdded = DateTime.Parse("2021-2-10"),
                        Note = "God wants us to return to Him."
                    },

                    new Scripture
                    {
                        Book = "D&C",
                        Chapter = "138",
                        Verse = "42",
                        DateAdded = DateTime.Parse("2021-2-15"),
                        Note = "After His Resurrection..."
                    },

                    new Scripture
                    {
                        Book = "Alma",
                        Chapter = "7",
                        Verse = "12",
                        DateAdded = DateTime.Parse("2021-2-25"),
                        Note = "The Savior suffered what we suffer so He can lift us up."
                    },

                    new Scripture
                    {
                        Book = "Matthew",
                        Chapter = "11",
                        Verse = "28",
                        DateAdded = DateTime.Parse("2021-1-20"),
                        Note = "He will take our burdens."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

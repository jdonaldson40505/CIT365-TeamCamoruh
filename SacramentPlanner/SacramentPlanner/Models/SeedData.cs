using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Data;
namespace SacramentPlanner.Models
{
    public class SeedData
    {
        
            public static void Initialize(IServiceProvider serviceProvider)
            {
            using (var context = new SacramentPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentPlannerContext>>()))
            {
                // Look for any movies.
                if (context.Meeting.Any())
                {
                    return;   // DB has been seeded
                }

                context.Meeting.AddRange(
                    new Meeting
                    {
                        Conductor = "Two Pauc",
                        Date = DateTime.Parse("12/10/2022"),
                        OpeningHymn = "341",
                        SacramentHymn = "176",
                        IntermediateHymn = "242",
                        ClosingHymn = "251",
                        OpeningPrayer = "kevin Hart",
                        ClosingPrayer = "Snoop Dogg",
                        speakers = new List<Speaker> { new Speaker {Name = "Logic", Topic = "Solomon Song" } }
                    },


                    new Meeting
                    {
                        
                        Conductor = "Obi Wan Kenobi",
                        Date = DateTime.Parse("12/03/2022"),
                        OpeningHymn = "310",
                        SacramentHymn = "172",
                        IntermediateHymn = "212",
                        ClosingHymn = "232",
                        OpeningPrayer = "Luke Skywalker",
                        ClosingPrayer = "Anakin Skywalker",
                        speakers = new List<Speaker> { new Speaker {Name = "Yoda", Topic = "Repentance" }, new Speaker { Name = "Darth Maul", Topic = "King David" } }
                    },

                    new Meeting
                    {
                        
                        Conductor = "Shaun White",
                        Date = DateTime.Parse("12/17/2022"),
                        OpeningHymn = "341",
                        SacramentHymn = "176",
                        IntermediateHymn = "242",
                        ClosingHymn = "251",
                        OpeningPrayer = "Torstien Horgmo",
                        ClosingPrayer = "Jeremy Jones",
                        speakers = new List<Speaker> { new Speaker { Name = "Travis Rice", Topic = "How to Shred" }, new Speaker {  Name = "Linn Huag", Topic = "Carving the temptations of the devil" } }
                    },

                    new Meeting
                    {
                    
                        Conductor = "Arnold Schwarzenegger",
                        Date = DateTime.Parse("12/24/2022"),
                        OpeningHymn = "300",
                        SacramentHymn = "178",
                        IntermediateHymn = "145",
                        ClosingHymn = "132",
                        OpeningPrayer = "Eddie Hall",
                        ClosingPrayer = "Halfthor Bjornsen",
                        speakers = new List<Speaker> { new Speaker { Name = "Brian Shaw", Topic = "Exercising Your Faith" } }

                    }
                );
          
                    context.SaveChanges();
                }
            }
        }
    
}

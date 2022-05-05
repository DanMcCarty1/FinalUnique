using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace FinalUnique.Models
{
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var db = new CardContext(serviceProvider.GetRequiredService<DbContextOptions<CardContext>>()))
        {
            if (db.Card.Any())
            {
                return;
            }
            db.Card.AddRange(
                new Card
                {
                    CardName = "Thoughtseize",
                    CardColor= "Black",
                    CardPrice = 25M,
                    Rarity = "Rare",
                    ExspansionName = "Theros"
                },
                new Card
                {
                    CardName = "Snapcaster",
                    CardColor= "Blue",
                    CardPrice = 33m,
                    Rarity = "Rare",
                    ExspansionName = "Innistrad"
                    
                },
                new Card
                {
                    CardName = "Counterspell",
                    CardColor= "Blue",
                    CardPrice = 800m,
                    Rarity = "Rare",
                    ExspansionName = "Beta"
                },
                new Card
                {
                    CardName = "Lightning Bolt",
                    CardColor= "Red",
                    CardPrice = 600,
                    Rarity = "Common",
                    ExspansionName = "Judge"
                }
            );
            db.SaveChanges();
        }
    }
}
}
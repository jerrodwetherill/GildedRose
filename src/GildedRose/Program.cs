using GildedRoseKata.Constants;
using GildedRoseKata.Entities;
using GildedRoseKata.Factories;
using GildedRoseKata.Services;
using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            int noDays = 30;
            if (args.Length != 0 )
            {
                if (!int.TryParse(args[0], out noDays))
                {
                    Console.WriteLine("Please enter a numeric argument.");
                    return;
                }

                noDays = Convert.ToInt32(args[0]);
            }

            IList<Item> Items = PopulateItemList();

            var itemUpdaterService = new ItemUpdaterService(new UpdaterStrategyFactory());
            var app = new GildedRose(Items, itemUpdaterService); 

            for (var i = 0; i <= noDays; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine(app.OutputStatus());
                app.UpdateQuality();
            }
        }
    
        private static IList<Item> PopulateItemList()
        {
            return new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = ItemNames.AgedBrie, SellIn = 2, Quality = 0},
                new Item {Name = ItemNames.ElixirOfMongoose, SellIn = 5, Quality = 7},
                new Item {Name = ItemNames.SulphurusOfRagnaros, SellIn = 0, Quality = 80},
                new Item {Name = ItemNames.SulphurusOfRagnaros, SellIn = -1, Quality = 80},
                new Item
                {
                    Name = ItemNames.BackstagePass,
                    SellIn = 15, 
                    Quality = 20 
                },
                new Item
                {
                    Name = ItemNames.BackstagePass,
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = ItemNames.BackstagePass,
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new Item {Name = ItemNames.Conjured, SellIn = 3, Quality = 6}
            };
            
        }
    }
}

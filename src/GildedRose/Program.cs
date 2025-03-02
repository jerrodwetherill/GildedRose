using GildedRoseKata.Items.Constants;
using GildedRoseKata.Items.Entities;
using GildedRoseKata.Items.Factories;
using GildedRoseKata.Items.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
        
            IList<Item> Items = PopulateItemList();

            var itemUpdaterService = new ItemUpdaterService(new UpdaterStrategyFactory());
            var app = new GildedRose(Items, itemUpdaterService);
            
            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine(OutputCurrentStatus(app.Inventory));
                app.UpdateQuality();
            }
        }

        private static string OutputCurrentStatus(IList<Item> items)
        {
            var itemOutputs = new StringBuilder();

            itemOutputs.AppendLine("name, sellIn, quality");
            foreach (var item in items)
            {
                itemOutputs.AppendLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
            }

            return itemOutputs.ToString();
        }

        private static IList<Item> PopulateItemList()
        {
            return new List<Item>
            {
                new Item {Name = ItemNames.DexterityVest, SellIn = 10, Quality = 20},
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

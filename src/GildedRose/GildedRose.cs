using GildedRoseKata.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        private readonly IUpdaterStrategyFactory _strategyFactory;

        public GildedRose(IList<Item> Items, IUpdaterStrategyFactory strategyFactory)
        {
            this.Items = Items;
            this._strategyFactory = strategyFactory;
        }

        public void UpdateQuality()
        {            
            for (var i = 0; i < Items.Count; i++)
            {
                var updater = _strategyFactory.CreateUpdater(Items[i]);
                Items[i] = updater.UpdateQuality(Items[i]);                
            }
        }

        public string OutputStatus()
        {
            var itemOutputs = new StringBuilder();

            itemOutputs.AppendLine("name, sellIn, quality");
            foreach (var item in Items)
            {
                itemOutputs.AppendLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
            }

            return itemOutputs.ToString();
        }
    }
}

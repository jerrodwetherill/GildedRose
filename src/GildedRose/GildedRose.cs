using GildedRoseKata.Entities;
using GildedRoseKata.Services;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        private readonly IItemUpdaterService _itemUpdaterService;

        public GildedRose(IList<Item> Items, IItemUpdaterService itemUpdaterService)
        {
            this.Items = Items;
            this._itemUpdaterService = itemUpdaterService;
        }

        public void UpdateQuality()
        {
            _itemUpdaterService.UpdateQuality(Items);
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

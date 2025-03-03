using GildedRoseKata.Inventory.Entities;
using GildedRoseKata.Inventory.Services;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private readonly IItemUpdaterService _itemUpdaterService;

        IList<Item> Items;

        public IList<Item> Inventory
        {
            get
            {
                return Items;
            }
        }

        public GildedRose(IList<Item> items, IItemUpdaterService itemUpdaterService)
        {
            Items = CloneItems(items);

            _itemUpdaterService = itemUpdaterService;
        }

        public void UpdateQuality()
        {
            _itemUpdaterService.UpdateQuality(Items);
        }
   
        private IList<Item> CloneItems(IList<Item> items)
        {
            var clonedCopy = new List<Item>();

            foreach (var item in items)
            {
                clonedCopy.Add(new Item { Name = item.Name, Quality = item.Quality, SellIn = item.SellIn});
            }

            return clonedCopy;
        }
    }
}

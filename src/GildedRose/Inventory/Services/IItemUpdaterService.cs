using GildedRoseKata.Inventory.Entities;
using System.Collections.Generic;

namespace GildedRoseKata.Inventory.Services
{
    public interface IItemUpdaterService
    {
        public void UpdateQuality(IList<Item> items);
    }
}

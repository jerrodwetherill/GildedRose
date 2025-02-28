using GildedRoseKata.Entities;
using System.Collections.Generic;

namespace GildedRoseKata.Services
{
    public interface IItemUpdaterService
    {
        public void UpdateQuality(IList<Item> items);
    }
}

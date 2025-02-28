using GildedRoseKata.Items.Entities;
using System.Collections.Generic;

namespace GildedRoseKata.Items.Services
{
    public interface IItemUpdaterService
    {
        public void UpdateQuality(IList<Item> items);
    }
}

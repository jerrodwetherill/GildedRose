using GildedRoseKata.Items.Entities;
using GildedRoseKata.Items.Factories;
using System.Collections.Generic;

namespace GildedRoseKata.Items.Services
{
    public class ItemUpdaterService : IItemUpdaterService
    {
        private readonly IUpdaterStrategyFactory _updaterStrategyFactory;

        public ItemUpdaterService(IUpdaterStrategyFactory updaterStrategyFactory)
        {
            _updaterStrategyFactory = updaterStrategyFactory;
        }

        public void UpdateQuality(IList<Item> items)
        {
            for (var i = 0; i < items.Count; i++)
            {
                items[i] = UpdateItem(items[i]);
            }
        }

        private Item UpdateItem(Item item)
        {
            var updater = _updaterStrategyFactory.CreateStrategy(item);
            return updater.UpdateQuality(item);
        }
    }
}

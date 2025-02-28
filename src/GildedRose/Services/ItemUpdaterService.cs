using GildedRoseKata.Entities;
using GildedRoseKata.Factories;
using System.Collections.Generic;

namespace GildedRoseKata.Services
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
                var updater = _updaterStrategyFactory.CreateStrategy(items[i]);
                items[i] = updater.UpdateQuality(items[i]);
            }
        }
    }
}

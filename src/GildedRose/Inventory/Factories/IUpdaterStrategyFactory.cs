using GildedRoseKata.Inventory.Entities;
using GildedRoseKata.Inventory.Strategies;

namespace GildedRoseKata.Inventory.Factories
{
    public interface IUpdaterStrategyFactory
    {
        public IItemUpdaterStrategy CreateStrategy(Item item);
    }
}

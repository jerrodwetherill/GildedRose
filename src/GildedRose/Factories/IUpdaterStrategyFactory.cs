using GildedRoseKata.Entities;
using GildedRoseKata.Strategies;

namespace GildedRoseKata.Factories
{
    public interface IUpdaterStrategyFactory
    {
        public IUpdaterStrategy CreateStrategy(Item item);
    }
}

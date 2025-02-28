using GildedRoseKata.Items.Entities;
using GildedRoseKata.Items.Strategies;

namespace GildedRoseKata.Items.Factories
{
    public interface IUpdaterStrategyFactory
    {
        public IUpdaterStrategy CreateStrategy(Item item);
    }
}

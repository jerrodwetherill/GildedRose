using GildedRoseKata.Constants;
using GildedRoseKata.Entities;
using GildedRoseKata.Strategies;

namespace GildedRoseKata.Factories
{
    public class UpdaterStrategyFactory : IUpdaterStrategyFactory
    {
        public IUpdaterStrategy CreateStrategy(Item item)
        {
            if (item.Name == ItemNames.AgedBrie)
            {
                return new BrieItemUpdaterStrategy();
            }
            else if (item.Name == ItemNames.BackstagePass)
            {
                return new BackStagePassItemUpdaterStrategy();
            }
            else if (item.Name == ItemNames.SulphurusOfRagnaros)
            {
                return new DoNothingItemUpdaterStrategy();
            }
            else if (item.Name == ItemNames.Conjured)
            {
                return new ConjuredItemUpdaterStrategy();
            }
            else
            {
                return new GenericItemUpdaterStrategy();
            }
        }
    }
}

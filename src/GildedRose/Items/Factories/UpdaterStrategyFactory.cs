using GildedRoseKata.Items.Constants;
using GildedRoseKata.Items.Entities;
using GildedRoseKata.Items.Strategies;

namespace GildedRoseKata.Items.Factories
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
                return new SulphurusItemUpdaterStrategy();
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

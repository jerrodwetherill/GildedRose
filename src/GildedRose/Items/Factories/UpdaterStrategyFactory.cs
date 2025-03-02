using GildedRoseKata.Items.Constants;
using GildedRoseKata.Items.Entities;
using GildedRoseKata.Items.Strategies;

namespace GildedRoseKata.Items.Factories
{
    public class UpdaterStrategyFactory : IUpdaterStrategyFactory
    {
        public IItemUpdaterStrategy CreateStrategy(Item item)
        {
            switch (item.Name)
            {
                case ItemNames.AgedBrie:
                    return new BrieItemUpdaterStrategy();
                case ItemNames.BackstagePass:
                    return new BackStagePassItemUpdaterStrategy();
                case ItemNames.SulphurusOfRagnaros:
                    return new LegendaryItemUpdaterStrategy();
                case ItemNames.Conjured:
                    return new ConjuredItemUpdaterStrategy();                
                default:
                    return new GenericItemUpdaterStrategy();
            }
        }
    }
}

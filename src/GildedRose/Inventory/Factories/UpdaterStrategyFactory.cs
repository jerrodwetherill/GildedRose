using GildedRoseKata.Inventory.Constants;
using GildedRoseKata.Inventory.Entities;
using GildedRoseKata.Inventory.Strategies;

namespace GildedRoseKata.Inventory.Factories
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

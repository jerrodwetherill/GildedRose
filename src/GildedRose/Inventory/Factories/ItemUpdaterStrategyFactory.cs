using GildedRoseKata.Inventory.Constants;
using GildedRoseKata.Inventory.Entities;
using GildedRoseKata.Inventory.Strategies;
using GildedRoseTests.Inventory.Validators;

namespace GildedRoseKata.Inventory.Factories
{
    public class ItemUpdaterStrategyFactory : IItemUpdaterStrategyFactory
    {
        public IItemUpdaterStrategy CreateStrategy(Item item)
        {
            switch (item.Name)
            {
                case ItemNames.AgedBrie:
                    return new BrieItemUpdaterStrategy(new DefaultItemValidator());
                case ItemNames.BackstagePass:
                    return new BackStagePassItemUpdaterStrategy(new DefaultItemValidator());
                case ItemNames.SulphurusOfRagnaros:
                    return new LegendaryItemUpdaterStrategy(new LegendaryItemValidator());
                case ItemNames.Conjured:
                    return new ConjuredItemUpdaterStrategy(new DefaultItemValidator());
                default:
                    return new GenericItemUpdaterStrategy(new DefaultItemValidator());
            }
        }
    }
}

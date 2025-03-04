using GildedRoseKata.Inventory.Entities;
using GildedRoseTests.Inventory.Validators;

namespace GildedRoseKata.Inventory.Strategies
{
    public class LegendaryItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
        public LegendaryItemUpdaterStrategy(IItemValidator itemValidator) : base(itemValidator)
        {

        }

        protected override void UpdateStrategyQuality(Item item)
        {
            //Do nothing
        }
    }
}

using GildedRoseKata.Inventory.Entities;
using GildedRoseTests.Inventory.Validators;

namespace GildedRoseKata.Inventory.Strategies
{
    public class BrieItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
        public BrieItemUpdaterStrategy(IItemValidator itemValidator) : base(itemValidator)
        {

        }

        protected override void UpdateStrategyQuality(Item item)
        {
            IncreaseQuality(item);
            DecreaseSellin(item);

            if (item.SellIn < 0)
            {
                IncreaseQuality(item);
            }
        }
    }
}

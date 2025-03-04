using GildedRoseKata.Inventory.Entities;
using GildedRoseTests.Inventory.Validators;

namespace GildedRoseKata.Inventory.Strategies
{
    public class ConjuredItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
        public ConjuredItemUpdaterStrategy(IItemValidator itemValidator) : base(itemValidator)
        {

        }

        protected override void UpdateStrategyQuality(Item item)
        {
            DecreaseQuality(item);
            DecreaseQuality(item);

            DecreaseSellin(item);

            if (item.SellIn < 0)
            {
                DecreaseQuality(item);
                DecreaseQuality(item);
            }
        }
    }
}

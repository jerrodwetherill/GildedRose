using GildedRoseKata.Inventory.Entities;
using GildedRoseTests.Inventory.Validators;

namespace GildedRoseKata.Inventory.Strategies
{
    public class BackStagePassItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
        public BackStagePassItemUpdaterStrategy(IItemValidator itemValidator) : base(itemValidator)
        {
        
        }

        protected override void UpdateStrategyQuality(Item item)
        {
            IncreaseQuality(item);

            if (item.SellIn < 11)
            {
                IncreaseQuality(item);
            }

            if (item.SellIn < 6)
            {
                IncreaseQuality(item);
            }

            DecreaseSellin(item);

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
    }
}

using GildedRoseKata.Inventory.Entities;
using GildedRoseTests.Inventory.Validators;

namespace GildedRoseKata.Inventory.Strategies
{
    public class GenericItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
        public GenericItemUpdaterStrategy(IItemValidator itemValidator) : base(itemValidator)
        {

        }

        protected override void UpdateStrategyQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }

            DecreaseSellin(item);

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality--;
                }
            }
        }
    }
}

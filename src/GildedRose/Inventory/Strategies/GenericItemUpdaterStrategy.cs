using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Strategies
{
    public class GenericItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
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

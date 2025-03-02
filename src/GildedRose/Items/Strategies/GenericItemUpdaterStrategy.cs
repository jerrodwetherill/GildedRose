using GildedRoseKata.Items.Entities;

namespace GildedRoseKata.Items.Strategies
{
    public class GenericItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
        protected override void UpdateStrategyQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }

            base.DecreaseSellin(item);

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

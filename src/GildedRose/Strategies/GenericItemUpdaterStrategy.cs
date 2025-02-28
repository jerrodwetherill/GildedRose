using GildedRoseKata.Entities;

namespace GildedRoseKata.Strategies
{
    public class GenericItemUpdaterStrategy : UpdaterStrategyBase
    {
        protected override void UpdateStrategyQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }

            item.SellIn--;

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

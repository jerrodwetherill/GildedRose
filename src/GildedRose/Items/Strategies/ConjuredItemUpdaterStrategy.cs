using GildedRoseKata.Items.Entities;

namespace GildedRoseKata.Items.Strategies
{
    public class ConjuredItemUpdaterStrategy : UpdaterStrategyBase
    {
        protected override void UpdateStrategyQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 2;
            }

            item.SellIn--;

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 2;
                }
            }
        }
    }
}

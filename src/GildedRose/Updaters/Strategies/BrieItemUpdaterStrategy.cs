namespace GildedRoseKata.Updaters.Strategies
{
    public class BrieItemUpdaterStrategy : UpdaterStrategyBase
    {
        protected override void UpdateStrategyQuality(Item item)
        {

            if (item.Quality < 50)
            {
                item.Quality++;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality < 50)
                {
                    item.Quality++;
                }
            }


        }
    }
}

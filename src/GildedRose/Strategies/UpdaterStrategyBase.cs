using GildedRoseKata.Entities;

namespace GildedRoseKata.Strategies
{
    public abstract class UpdaterStrategyBase : IUpdaterStrategy
    {
        protected abstract void UpdateStrategyQuality(Item item);

        public Item UpdateQuality(Item item)
        {
            UpdateStrategyQuality(item);

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }

            return item;
        }
    }


}

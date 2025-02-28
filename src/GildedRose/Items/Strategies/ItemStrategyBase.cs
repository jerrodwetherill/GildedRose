using GildedRoseKata.Items.Entities;

namespace GildedRoseKata.Items.Strategies
{
    public abstract class ItemStrategyBase : IUpdaterStrategy
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

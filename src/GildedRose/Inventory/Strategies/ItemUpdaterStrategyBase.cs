using GildedRoseKata.Inventory.Entities;
using System;

namespace GildedRoseKata.Inventory.Strategies
{
    public abstract class ItemUpdaterStrategyBase : IItemUpdaterStrategy
    {
        protected abstract void UpdateStrategyQuality(Item item);

        public Item UpdateQuality(Item item)
        {
            UpdateStrategyQuality(item);
            Validate(item);

            return item;
        }

        private void Validate(Item item)
        {
            if (item.Quality < 0)
            {
                throw new Exception("Quality cannot be negative");
            }

            if (GetType() != typeof(LegendaryItemUpdaterStrategy))
            {
                if (item.Quality > 50)
                {
                    throw new Exception("Quality cannot be more than 50 for non legendary items");
                }
            }
        }

        protected void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }

        protected void DecreaseQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
        }

        protected void DecreaseSellin(Item item)
        {
            item.SellIn = item.SellIn - 1;
        }
    }
}

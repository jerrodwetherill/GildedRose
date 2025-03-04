using GildedRoseKata.Inventory.Entities;
using GildedRoseTests.Inventory.Validators;
using System;

namespace GildedRoseKata.Inventory.Strategies
{
    public abstract class ItemUpdaterStrategyBase : IItemUpdaterStrategy
    {
        private readonly IItemValidator _itemValidator;

        public ItemUpdaterStrategyBase(IItemValidator itemValidator)
        {
            _itemValidator = itemValidator;
        }
        

        protected abstract void UpdateStrategyQuality(Item item);

        public Item UpdateQuality(Item item)
        {
            UpdateStrategyQuality(item);
            _itemValidator.Validate(item);

            return item;
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

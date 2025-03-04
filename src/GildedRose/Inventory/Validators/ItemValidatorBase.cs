using GildedRoseKata.Inventory.Entities;
using System;

namespace GildedRoseTests.Inventory.Validators
{
    public class ItemValidatorBase : IItemValidator
    {
        public virtual void Validate(Item item)
        {
            if (item.Quality < 0)
            {
                throw new Exception("Quality cannot be negative");
            }
        }
    }
}
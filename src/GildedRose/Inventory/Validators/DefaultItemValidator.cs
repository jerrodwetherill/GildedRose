using GildedRoseKata.Inventory.Entities;
using System;

namespace GildedRoseTests.Inventory.Validators
{

    public class DefaultItemValidator : ItemValidatorBase 
    {
        public override void Validate(Item item)
        {
            if (item.Quality > 50)
            {
                throw new Exception("Quality cannot be more than 50 for non legendary items");
            }

            base.Validate(item);
        }
    }
}
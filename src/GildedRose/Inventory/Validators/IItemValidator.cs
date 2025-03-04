using GildedRoseKata.Inventory.Entities;

namespace GildedRoseTests.Inventory.Validators
{
    public interface IItemValidator
    {
        public void Validate(Item item);
    }
}
using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Strategies
{
    public interface IItemUpdaterStrategy
    {
        public Item UpdateQuality(Item item);
    }
}

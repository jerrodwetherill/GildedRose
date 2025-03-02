using GildedRoseKata.Items.Entities;

namespace GildedRoseKata.Items.Strategies
{
    public interface IItemUpdaterStrategy
    {
        public Item UpdateQuality(Item item);
    } 
}

using GildedRoseKata.Items.Entities;

namespace GildedRoseKata.Items.Strategies
{
    public interface IUpdaterStrategy
    {
        public Item UpdateQuality(Item item);
    }
}

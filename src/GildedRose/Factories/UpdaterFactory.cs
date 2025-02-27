using GildedRoseKata.Updaters;
namespace GildedRoseKata.Factories
{
    public class UpdaterFactory : IUpdaterFactory
    {
        public IUpdater CreateUpdater(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                return new BrieItemUpdater(item);
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                return new BackStagePassItemUpdater(item);
            }
            else if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                return new DoNothingItemUpdater(item);
            }
            else if (item.Name == "Conjured Mana Cake")
            {
                return new ConjuredItemUpdater(item);
            }
            else
            {
                return new GenericItemUpdater(item);
            }
        }
    }
}

using GildedRoseKata.Updaters.Strategies;
namespace GildedRoseKata.Factories
{
    public class UpdaterStrategyFactory : IUpdaterStrategyFactory
    {
        public IUpdaterStrategy CreateUpdater(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                return new BrieItemUpdaterStrategy();
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                return new BackStagePassItemUpdaterStrategy();
            }
            else if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                return new DoNothingItemUpdaterStrategy();
            }
            else if (item.Name == "Conjured Mana Cake")
            {
                return new ConjuredItemUpdaterStrategy();
            }
            else
            {
                return new GenericItemUpdaterStrategy();
            }
        }
    }
}

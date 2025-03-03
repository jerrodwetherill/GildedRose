using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Strategies
{
    public class BackStagePassItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
        protected override void UpdateStrategyQuality(Item item)
        {
            IncreaseQuality(item);

            if (item.SellIn < 11)
            {
                IncreaseQuality(item);
            }

            if (item.SellIn < 6)
            {
                IncreaseQuality(item);
            }

            DecreaseSellin(item);

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
    }
}

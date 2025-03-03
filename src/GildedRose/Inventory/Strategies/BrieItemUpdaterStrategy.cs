using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Strategies
{
    public class BrieItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
        protected override void UpdateStrategyQuality(Item item)
        {
            IncreaseQuality(item);
            DecreaseSellin(item);

            if (item.SellIn < 0)
            {
                IncreaseQuality(item);
            }
        }
    }
}

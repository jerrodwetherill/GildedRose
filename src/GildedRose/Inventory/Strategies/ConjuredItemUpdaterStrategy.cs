using GildedRoseKata.Inventory.Entities;

namespace GildedRoseKata.Inventory.Strategies
{
    public class ConjuredItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
        protected override void UpdateStrategyQuality(Item item)
        {
            DecreaseQuality(item);
            DecreaseQuality(item);

            DecreaseSellin(item);

            if (item.SellIn < 0)
            {
                DecreaseQuality(item);
                DecreaseQuality(item);
            }
        }
    }
}

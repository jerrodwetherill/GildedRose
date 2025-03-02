using GildedRoseKata.Items.Entities;

namespace GildedRoseKata.Items.Strategies
{
    public class ConjuredItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
        protected override void UpdateStrategyQuality(Item item)
        {
            base.DecreaseQuality(item);
            base.DecreaseQuality(item);

            base.DecreaseSellin(item);

            if (item.SellIn < 0)
            {
                base.DecreaseQuality(item);
                base.DecreaseQuality(item);
            }
        }
    }
}

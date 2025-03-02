using GildedRoseKata.Items.Entities;

namespace GildedRoseKata.Items.Strategies
{
    public class BrieItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
        protected override void UpdateStrategyQuality(Item item)
        {
            base.IncreaseQuality(item);
            base.DecreaseSellin(item);

            if (item.SellIn < 0)
            {
                base.IncreaseQuality(item);
            }
        }
    }
}

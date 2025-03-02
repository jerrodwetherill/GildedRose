using GildedRoseKata.Items.Entities;

namespace GildedRoseKata.Items.Strategies
{
    public class BackStagePassItemUpdaterStrategy : ItemUpdaterStrategyBase
    {
        protected override void UpdateStrategyQuality(Item item)
        {
            base.IncreaseQuality(item);

            if (item.SellIn < 11)
            {
                base.IncreaseQuality(item);
            }

            if (item.SellIn < 6)
            {
                base.IncreaseQuality(item);
            }

            base.DecreaseSellin(item);            

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
    }
}

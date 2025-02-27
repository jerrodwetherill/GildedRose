namespace GildedRoseKata.Updaters
{
    public class DoNothingItemUpdater : UpdaterBase
    {
        public DoNothingItemUpdater(Item item) : base(item)
        {

        }

        protected override void UpdateStrategy()
        {
            //Do nothing
        }
    }
}

namespace GildedRoseKata.Updaters
{
    public class GenericItemUpdater : UpdaterBase
    {
        public GenericItemUpdater(Item item) : base(item)
        {

        }

        protected override void UpdateStrategy()
        {            
            if (_item.Quality > 0)
            {                
                _item.Quality--;
            }

            _item.SellIn--;

            if (_item.SellIn < 0)
            {
                if (_item.Quality > 0)
                {
                    _item.Quality--;
                }
            }

        }
    }
}

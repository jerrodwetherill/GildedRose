namespace GildedRoseKata.Updaters
{
    public class BrieItemUpdater : UpdaterBase
    {
        public BrieItemUpdater(Item item) : base(item)
        {

        }

        protected override void UpdateStrategy()
        {
           
            if (_item.Quality < 50)
            {
                _item.Quality++;
            }

            _item.SellIn = _item.SellIn - 1;

            if (_item.SellIn < 0)
            {
                if (_item.Quality < 50)
                {
                    _item.Quality++; 
                }
            }


        }
    }
}

namespace GildedRoseKata.Updaters
{
    public class BackStagePassItemUpdater : UpdaterBase
    {
        public BackStagePassItemUpdater(Item item) : base(item)
        {

        }

        protected override void UpdateStrategy()
        {
            if (_item.Quality < 50)
            {
                _item.Quality = _item.Quality + 1;
            }

            if (_item.SellIn < 11)
            {
                if (_item.Quality < 50)
                {
                    _item.Quality = _item.Quality + 1;
                }
            }

            if (_item.SellIn < 6)
            {
                if (_item.Quality < 50)
                {
                    _item.Quality = _item.Quality + 1;
                }
            }

            _item.SellIn = _item.SellIn - 1;

            if (_item.SellIn < 0)
            {
                _item.Quality = 0;
            }


        }
    }
}

namespace GildedRoseKata.Updaters
{
    public abstract class UpdaterBase : IUpdater
    {
        protected readonly Item _item;
        protected abstract void UpdateStrategy();
        
        public UpdaterBase(Item item)
        {
            _item = item;
        }

        public Item UpdateItem()
        {
            UpdateStrategy();

            if (_item.Quality < 0)
            {
                _item.Quality = 0;
            }            

            return _item;
        }
    }


}

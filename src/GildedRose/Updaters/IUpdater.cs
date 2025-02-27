using System;
using System.Reflection.Metadata.Ecma335;

namespace GildedRoseKata.Updaters
{
    public interface IUpdater
    {
        public Item UpdateItem();
    }

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

    public class ConjuredItemUpdater : UpdaterBase
    {
        public ConjuredItemUpdater(Item item) : base(item)
        {

        }

        protected override void UpdateStrategy()
        {
            if (_item.Quality > 0)
            {
                _item.Quality--;
                _item.Quality--;
            }

            _item.SellIn--;

            if (_item.SellIn < 0)
            {
                if (_item.Quality > 0)
                {
                    _item.Quality--;
                    _item.Quality--;
                }
            }

        }
    }


}

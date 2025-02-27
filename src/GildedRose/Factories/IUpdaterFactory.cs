using GildedRoseKata.Updaters;
using System;
namespace GildedRoseKata.Factories
{
    public interface IUpdaterFactory
    {
        public IUpdater CreateUpdater(Item item);
    }
}

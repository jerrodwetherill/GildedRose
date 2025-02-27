using GildedRoseKata.Updaters.Strategies;
using System;
namespace GildedRoseKata.Factories
{
    public interface IUpdaterStrategyFactory
    {
        public IUpdaterStrategy CreateUpdater(Item item);
    }
}

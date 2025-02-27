using GildedRoseKata.Factories;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        private readonly IUpdaterFactory _updaterFactory;

        public GildedRose(IList<Item> Items, IUpdaterFactory updaterFactory)
        {
            this.Items = Items;
            this._updaterFactory = updaterFactory;
        }

        public void UpdateQuality()
        {            
            for (var i = 0; i < Items.Count; i++)
            {
                var updater = _updaterFactory.CreateUpdater(Items[i]);
                Items[i] = updater.UpdateItem();                
            }
        }
    }
}

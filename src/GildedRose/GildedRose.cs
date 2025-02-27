using GildedRoseKata.Updaters;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {            
            for (var i = 0; i < Items.Count; i++)
            {
                IUpdater updater;
                
                if (Items[i].Name == "Aged Brie")
                {
                    updater = new BrieItemUpdater(Items[i]);
                    Items[i] = updater.UpdateItem();                  
                }
                else if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    updater = new BackStagePassItemUpdater(Items[i]);
                    Items[i] = updater.UpdateItem();                    
                }
                else if (Items[i].Name == "Sulfuras, Hand of Ragnaros")
                {

                }
                else if (Items[i].Name == "Conjured Mana Cake")
                {
                    updater = new ConjuredItemUpdater(Items[i]);
                    Items[i] = updater.UpdateItem();
                }
                else
                {
                    updater = new GenericItemUpdater(Items[i]);
                    Items[i] = updater.UpdateItem();                   
                }
               
            }
        }
    }
}

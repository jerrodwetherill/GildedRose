using Xunit;
using GildedRoseKata;
using GildedRoseKata.Updaters;
using GildedRoseKata.Factories;

namespace GildedRoseTests.Factories
{
    public class UpdaterFactoryTest
    {

        [Fact]
        public void Brie_Item_Creates_Correct_Updater()
        {
            //Arrange
            IUpdaterFactory updaterFactory = new UpdaterFactory();

            var item = new Item()
            {
                Name = "Aged Brie",
                Quality = 8,
                SellIn = 4
            };

            //Act
            IUpdater genericUpdate = updaterFactory.CreateUpdater(item);

            //Assert
            Assert.IsType<BrieItemUpdater>(genericUpdate);

        }

        [Fact]
        public void BackStagePass_Item_Creates_Correct_Updater()
        {
            //Arrange
            IUpdaterFactory updaterFactory = new UpdaterFactory();

            var item = new Item()
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 8,
                SellIn = 4
            };

            //Act
            IUpdater genericUpdate = updaterFactory.CreateUpdater(item);

            //Assert
            Assert.IsType<BackStagePassItemUpdater>(genericUpdate);

        }

        [Fact]
        public void Sulfuras_Item_Creates_Correct_Updater()
        {
            //Arrange
            IUpdaterFactory updaterFactory = new UpdaterFactory();

            var item = new Item()
            {
                Name = "Sulfuras, Hand of Ragnaros",
                Quality = 8,
                SellIn = 4
            };

            //Act
            IUpdater genericUpdate = updaterFactory.CreateUpdater(item);

            //Assert
            Assert.IsType<DoNothingItemUpdater>(genericUpdate);

        }

        [Fact]
        public void Conjured_Item_Creates_Correct_Updater()
        {
            //Arrange
            IUpdaterFactory updaterFactory = new UpdaterFactory();

            var item = new Item()
            {
                Name = "Conjured Mana Cake",
                Quality = 8,
                SellIn = 4
            };

            //Act
            IUpdater genericUpdate = updaterFactory.CreateUpdater(item);

            //Assert
            Assert.IsType<ConjuredItemUpdater>(genericUpdate);

        }

        [Fact]
        public void Unknown_Item_Creates_Correct_Updater()
        {
            //Arrange
            IUpdaterFactory updaterFactory = new UpdaterFactory();

            var item = new Item()
            {
                Name = "New item type",
                Quality = 8,
                SellIn = 4
            };

            //Act
            IUpdater genericUpdate = updaterFactory.CreateUpdater(item);

            //Assert
            Assert.IsType<GenericItemUpdater>(genericUpdate);

        }

    }

}

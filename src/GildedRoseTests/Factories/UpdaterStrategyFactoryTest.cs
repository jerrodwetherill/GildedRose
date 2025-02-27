using Xunit;
using GildedRoseKata;
using GildedRoseKata.Factories;
using GildedRoseKata.Updaters.Strategies;

namespace GildedRoseTests.Factories
{
    public class UpdaterStrategyFactoryTest
    {
        [Fact]
        public void Brie_Item_Creates_Correct_Updater()
        {
            //Arrange
            IUpdaterStrategyFactory strategyFactory = new UpdaterStrategyFactory();

            var item = new Item()
            {
                Name = "Aged Brie",
                Quality = 8,
                SellIn = 4
            };

            //Act
            IUpdaterStrategy genericUpdate = strategyFactory.CreateUpdater(item);

            //Assert
            Assert.IsType<BrieItemUpdaterStrategy>(genericUpdate);

        }

        [Fact]
        public void BackStagePass_Item_Creates_Correct_Updater()
        {
            //Arrange
            IUpdaterStrategyFactory strategyFactory = new UpdaterStrategyFactory();

            var item = new Item()
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                Quality = 8,
                SellIn = 4
            };

            //Act
            IUpdaterStrategy genericUpdate = strategyFactory.CreateUpdater(item);

            //Assert
            Assert.IsType<BackStagePassItemUpdaterStrategy>(genericUpdate);

        }

        [Fact]
        public void Sulfuras_Item_Creates_Correct_Updater()
        {
            //Arrange
            IUpdaterStrategyFactory strategyFactory = new UpdaterStrategyFactory();

            var item = new Item()
            {
                Name = "Sulfuras, Hand of Ragnaros",
                Quality = 8,
                SellIn = 4
            };

            //Act
            IUpdaterStrategy genericUpdate = strategyFactory.CreateUpdater(item);

            //Assert
            Assert.IsType<DoNothingItemUpdaterStrategy>(genericUpdate);

        }

        [Fact]
        public void Conjured_Item_Creates_Correct_Updater()
        {
            //Arrange
            IUpdaterStrategyFactory strategyFactory = new UpdaterStrategyFactory();

            var item = new Item()
            {
                Name = "Conjured Mana Cake",
                Quality = 8,
                SellIn = 4
            };

            //Act
            IUpdaterStrategy genericUpdate = strategyFactory.CreateUpdater(item);

            //Assert
            Assert.IsType<ConjuredItemUpdaterStrategy>(genericUpdate);

        }

        [Fact]
        public void Unknown_Item_Creates_Correct_Updater()
        {
            //Arrange
            IUpdaterStrategyFactory strategyFactory = new UpdaterStrategyFactory();

            var item = new Item()
            {
                Name = "New item type",
                Quality = 8,
                SellIn = 4
            };

            //Act
            IUpdaterStrategy genericUpdate = strategyFactory.CreateUpdater(item);

            //Assert
            Assert.IsType<GenericItemUpdaterStrategy>(genericUpdate);

        }

    }

}

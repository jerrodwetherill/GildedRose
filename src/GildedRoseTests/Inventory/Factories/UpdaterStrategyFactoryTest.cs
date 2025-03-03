using Xunit;
using GildedRoseKata.Inventory.Constants;
using GildedRoseKata.Inventory.Factories;
using GildedRoseKata.Inventory.Strategies;
using GildedRoseKata.Inventory.Entities;

namespace GildedRoseTests.Inventory.Factories
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
                Name = ItemNames.AgedBrie,
                Quality = 8,
                SellIn = 4
            };

            //Act
            IItemUpdaterStrategy genericUpdate = strategyFactory.CreateStrategy(item);

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
                Name = ItemNames.BackstagePass,
                Quality = 8,
                SellIn = 4
            };

            //Act
            IItemUpdaterStrategy genericUpdate = strategyFactory.CreateStrategy(item);

            //Assert
            Assert.IsType<BackStagePassItemUpdaterStrategy>(genericUpdate);

        }

        [Fact]
        public void Sulfuras_Item_Creates_Legendary_Updater()
        {
            //Arrange
            IUpdaterStrategyFactory strategyFactory = new UpdaterStrategyFactory();

            var item = new Item()
            {
                Name = ItemNames.SulphurusOfRagnaros,
                Quality = 8,
                SellIn = 4
            };

            //Act
            IItemUpdaterStrategy genericUpdate = strategyFactory.CreateStrategy(item);

            //Assert
            Assert.IsType<LegendaryItemUpdaterStrategy>(genericUpdate);

        }

        [Fact]
        public void Conjured_Item_Creates_Correct_Updater()
        {
            //Arrange
            IUpdaterStrategyFactory strategyFactory = new UpdaterStrategyFactory();

            var item = new Item()
            {
                Name = ItemNames.Conjured,
                Quality = 8,
                SellIn = 4
            };

            //Act
            IItemUpdaterStrategy genericUpdate = strategyFactory.CreateStrategy(item);

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
            IItemUpdaterStrategy genericUpdate = strategyFactory.CreateStrategy(item);

            //Assert
            Assert.IsType<GenericItemUpdaterStrategy>(genericUpdate);

        }

    }

}

using Xunit;
using System.Collections.Generic;
using Moq;
using GildedRoseKata.Inventory.Entities;
using GildedRoseKata.Inventory.Factories;
using GildedRoseKata.Inventory.Strategies;
using GildedRoseKata.Inventory.Services;
using GildedRoseTests.Inventory.Validators;

namespace GildedRoseTests.Inventory.Services
{
    public class ItemUpdaterServiceTest
    {
        [Fact]
        public void UpdateQuality_Calls_UpdaterStrategyFactory_CreateStrategy_Correct_Number_Of_Times()
        {
            //Arrange
            var strategy = new GenericItemUpdaterStrategy(new DefaultItemValidator());

            var updaterStrategyFactoryMock = new Mock<IItemUpdaterStrategyFactory>();
            updaterStrategyFactoryMock.Setup(r => r.CreateStrategy(It.IsAny<Item>()))
                .Returns(strategy);

            var items = new List<Item> {
                new Item { Name = "item1", SellIn = 0, Quality = 0 } ,
                new Item { Name = "item2", SellIn = 0, Quality = 0 }
            };

            var itemUpdaterService = new ItemUpdaterService(updaterStrategyFactoryMock.Object);

            //Act
            itemUpdaterService.UpdateQuality(items);

            //Assert
            updaterStrategyFactoryMock.Verify(r => r.CreateStrategy(It.IsAny<Item>()), Times.Exactly(2));
        }

        [Fact]
        public void UpdateQuality_Updates_All_Items()
        {
            //Arrange
            var strategy = new GenericItemUpdaterStrategy(new DefaultItemValidator());

            var items = new List<Item> {
                new Item { Name = "item1", SellIn = 10, Quality = 10 },
                new Item { Name = "item2", SellIn = 10, Quality = 12 }
            };

            var itemUpdaterService = new ItemUpdaterService(new ItemUpdaterStrategyFactory());

            //Act
            itemUpdaterService.UpdateQuality(items);

            //Assert
            Assert.Equal(9, items[0].Quality);
            Assert.Equal(9, items[0].SellIn);
            Assert.Equal(11, items[1].Quality);
            Assert.Equal(9, items[1].SellIn);
        }
    }
}

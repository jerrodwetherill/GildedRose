using Xunit;
using System.Collections.Generic;
using Moq;
using GildedRoseKata.Items.Entities;
using GildedRoseKata.Items.Factories;
using GildedRoseKata.Items.Strategies;
using GildedRoseKata.Items.Services;

namespace GildedRoseTests.Items.Services
{
    public class ItemUpdaterServiceTest
    {
        [Fact]
        public void UpdateQuality_Calls_UpdaterStrategyFactory_CreateStrategy_Correct_Number_Of_Times()
        {
            //Arrange
            var strategy = new GenericItemUpdaterStrategy();

            var updaterStrategyFactoryMock = new Mock<IUpdaterStrategyFactory>();
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
            var strategy = new GenericItemUpdaterStrategy();

            var items = new List<Item> {
                new Item { Name = "item1", SellIn = 10, Quality = 10 },
                new Item { Name = "item2", SellIn = 10, Quality = 12 }
            };

            var itemUpdaterService = new ItemUpdaterService(new UpdaterStrategyFactory());

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

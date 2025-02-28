using Xunit;
using System.Collections.Generic;
using Moq;
using GildedRoseKata.Services;
using GildedRoseKata.Factories;
using GildedRoseKata.Entities;
using GildedRoseKata.Strategies;

namespace GildedRoseTests
{
    public class ItemUpdaterServiceTest
    {
        [Fact]
        public void UpdateQuality_Calls_UpdaterStrategyFactory_CreateUpdater_Correct_Number_Of_Times()
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
    }
}

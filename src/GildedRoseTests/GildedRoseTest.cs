using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Factories;
using VerifyXunit;
using System.Threading.Tasks;
using Moq;
using GildedRoseKata.Updaters.Strategies;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQuality_Calls_UpdaterStrategyFactory_CreateUpdater_Correct_Numer_Of_Times()
        {
            //Arrange
            var strategy = new GenericItemUpdaterStrategy();
            var _strategyFactoryMock = new Mock<IUpdaterStrategyFactory>();
            _strategyFactoryMock.Setup(r => r.CreateUpdater(It.IsAny<Item>()))
                .Returns(strategy);

            var Items = new List<Item> { 
                new Item { Name = "item1", SellIn = 0, Quality = 0 } ,
                new Item { Name = "item2", SellIn = 0, Quality = 0 }
            };

            var app = new GildedRose(Items, _strategyFactoryMock.Object);

            //Act
            app.UpdateQuality();

            //Assert
            _strategyFactoryMock.Verify(r => r.CreateUpdater(It.IsAny<Item>()), Times.Exactly(2));
        }

        [Fact]
        public Task OutputStatus_Returns_Correct_Output()
        {
            //Arrange
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(Items, new UpdaterStrategyFactory());
            
            //Act
            var output = app.OutputStatus();

            //Assert
            return Verifier.Verify(output);
        }
    }
}

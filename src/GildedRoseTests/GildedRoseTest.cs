using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using VerifyXunit;
using System.Threading.Tasks;
using Moq;
using GildedRoseKata.Services;
using GildedRoseKata.Entities;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQuality_Calls_ItemUpdaterService_UpdateQuality_Correct_Number_Of_Times()
        {
            //Arrange
            var itemUpdaterServiceMock = new Mock<IItemUpdaterService>();
            itemUpdaterServiceMock.Setup(r => r.UpdateQuality(It.IsAny<List<Item>>()));

            var Items = new List<Item> { 
                new Item { Name = "item1", SellIn = 0, Quality = 0 } ,
                new Item { Name = "item2", SellIn = 0, Quality = 0 }
            };

            var app = new GildedRose(Items, itemUpdaterServiceMock.Object);

            //Act
            app.UpdateQuality();

            //Assert
            itemUpdaterServiceMock.Verify(r => r.UpdateQuality(It.IsAny<List<Item>>()), Times.Exactly(1));
        }

        [Fact]
        public Task OutputStatus_Returns_Correct_Output()
        {
            //Arrange
            var itemUpdaterServiceMock = new Mock<IItemUpdaterService>();
            
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(Items, itemUpdaterServiceMock.Object);
            
            //Act
            var output = app.OutputStatus();

            //Assert
            return Verifier.Verify(output);
        }
    }
}

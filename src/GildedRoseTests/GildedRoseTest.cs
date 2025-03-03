using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using Moq;
using GildedRoseKata.Inventory.Constants;
using GildedRoseKata.Inventory.Entities;
using GildedRoseKata.Inventory.Services;
using GildedRoseKata.Inventory.Factories;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQuality_With_Generic_Item_Updates_Correctly()
        {
            //Arrange
            var expectedQuality = 9;
            var expectedSellIn = 9;
            var updaterStrategyFactory = new ItemUpdaterStrategyFactory();
                        
            var Items = new List<Item> {
                new Item { Name = "item1", SellIn = 10, Quality = 10 }
            };

            var app = new GildedRose(Items, new ItemUpdaterService(updaterStrategyFactory));

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal(expectedQuality, app.Inventory[0].Quality);
            Assert.Equal(expectedSellIn, app.Inventory[0].SellIn);
        }

        [Fact]
        public void UpdateQuality_With_Aged_Brie_Item_Updates_Correctly()
        {
            //Arrange
            var expectedQuality = 11;
            var expectedSellIn = 9;
            var updaterStrategyFactory = new ItemUpdaterStrategyFactory();

            var Items = new List<Item> {
                new Item { Name = ItemNames.AgedBrie, SellIn = 10, Quality = 10 }
            };

            var app = new GildedRose(Items, new ItemUpdaterService(updaterStrategyFactory));

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal(expectedQuality, app.Inventory[0].Quality);
            Assert.Equal(expectedSellIn, app.Inventory[0].SellIn);
        }

        [Fact]
        public void UpdateQuality_With_Legendary_Item_Updates_Correctly()
        {
            //Arrange
            var expectedQuality = 10;
            var expectedSellIn = 10;
            var updaterStrategyFactory = new ItemUpdaterStrategyFactory();

            var Items = new List<Item> {
                new Item { Name = ItemNames.SulphurusOfRagnaros, SellIn = 10, Quality = 10 }
            };

            var app = new GildedRose(Items, new ItemUpdaterService(updaterStrategyFactory));

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal(expectedQuality, app.Inventory[0].Quality);
            Assert.Equal(expectedSellIn, app.Inventory[0].SellIn);
        }

        [Fact]
        public void UpdateQuality_With_BackstagePass_Item_Updates_Correctly()
        {
            //Arrange
            var expectedQuality = 11;
            var expectedSellIn = 11;
            var updaterStrategyFactory = new ItemUpdaterStrategyFactory();

            var Items = new List<Item> {
                new Item { Name = ItemNames.BackstagePass, SellIn = 12, Quality = 10 }
            };

            var app = new GildedRose(Items, new ItemUpdaterService(updaterStrategyFactory));

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal(expectedQuality, app.Inventory[0].Quality);
            Assert.Equal(expectedSellIn, app.Inventory[0].SellIn);
        }

        [Fact]
        public void UpdateQuality_With_Conjured_Item_Updates_Correctly()
        {
            //Arrange
            var expectedQuality = 8;
            var expectedSellIn = 11;
            var updaterStrategyFactory = new ItemUpdaterStrategyFactory();

            var Items = new List<Item> {
                new Item { Name = ItemNames.Conjured, SellIn = 12, Quality = 10 }
            };

            var app = new GildedRose(Items, new ItemUpdaterService(updaterStrategyFactory));

            //Act
            app.UpdateQuality();

            //Assert
            Assert.Equal(expectedQuality, app.Inventory[0].Quality);
            Assert.Equal(expectedSellIn, app.Inventory[0].SellIn);
        }

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
    }
}

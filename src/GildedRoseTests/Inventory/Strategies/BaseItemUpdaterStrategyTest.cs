using Xunit;
using System;
using GildedRoseKata.Inventory.Entities;
using GildedRoseKata.Inventory.Strategies;

namespace GildedRoseTests.Inventory.Strategies
{

    public class BaseItemUpdaterStrategyTest
    {
        private class TestItemUpdaterStrategyBase : ItemUpdaterStrategyBase
        {
            protected override void UpdateStrategyQuality(Item item)
            {

            }
        }

        [Fact]
        public void Quality_Set_To_Negative_UpdateQuality_Throws_Error()
        {
            //Arrange
            var expectedQuality = 80;
            var expectedSellin = 4;

            var item = new Item()
            {
                Name = "test Item",
                Quality = -1,
                SellIn = 4
            };

            IItemUpdaterStrategy genericUpdate = new TestItemUpdaterStrategyBase();

            //Assert
            Assert.Throws<Exception>(() => genericUpdate.UpdateQuality(item));
        }

        [Fact]
        public void Quality_Set_To_Negative_UpdateQuality_Error_Message_Is_Set()
        {
            //Arrange
            var expectedQuality = 80;
            var expectedSellin = 4;

            var item = new Item()
            {
                Name = "test Item",
                Quality = -1,
                SellIn = 4
            };

            IItemUpdaterStrategy genericUpdate = new TestItemUpdaterStrategyBase();

            //Assert
            var exception = Assert.Throws<Exception>(() => genericUpdate.UpdateQuality(item));
            Assert.Equal("Quality cannot be negative", exception.Message);
        }

        [Fact]
        public void Quality_Set_To_Above_50_UpdateQuality_Throws_Error()
        {
            //Arrange
            var expectedQuality = 80;
            var expectedSellin = 4;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 80,
                SellIn = 4
            };

            IItemUpdaterStrategy genericUpdate = new TestItemUpdaterStrategyBase();

            //Assert
            Assert.Throws<Exception>(() => genericUpdate.UpdateQuality(item));
        }

        [Fact]
        public void Quality_Set_To_Above_50_UpdateQuality_Error_Message_Is_Set()
        {
            //Arrange
            var expectedQuality = 80;
            var expectedSellin = 4;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 80,
                SellIn = 4
            };

            IItemUpdaterStrategy genericUpdate = new TestItemUpdaterStrategyBase();

            //Assert
            var exception = Assert.Throws<Exception>(() => genericUpdate.UpdateQuality(item));
            Assert.Equal("Quality cannot be more than 50 for non legendary items", exception.Message);
        }
    }
}

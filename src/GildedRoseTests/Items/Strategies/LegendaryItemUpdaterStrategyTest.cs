using Xunit;
using GildedRoseKata.Items.Strategies;
using GildedRoseKata.Items.Entities;

namespace GildedRoseTests.Items.Strategies
{
    public class LegendaryItemUpdaterStrategyTest
    {
        [Fact]
        public void Can_Set_Quantity_Above_50()
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

            IItemUpdaterStrategy genericUpdate = new LegendaryItemUpdaterStrategy();

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void In_Sellby_Date_Does_Not_Decrease_SellBy_Or_Quantity()
        {
            //Arrange
            var expectedQuality = 8;
            var expectedSellin = 4;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 8,
                SellIn = 4
            };

            IItemUpdaterStrategy genericUpdate = new LegendaryItemUpdaterStrategy();

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Past_Sellby_Date_Does_Not_Decrease_SellBy_Or_Quantity()
        {
            //Arrange
            var expectedQuality = 8;
            var expectedSellin = -1;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 8,
                SellIn = -1
            };

            IItemUpdaterStrategy genericUpdate = new LegendaryItemUpdaterStrategy();

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }
    
    }

}

using Xunit;
using GildedRoseKata.Inventory.Strategies;
using GildedRoseKata.Inventory.Entities;
using GildedRoseTests.Inventory.Validators;

namespace GildedRoseTests.Inventory.Strategies
{
    public class LegendaryItemUpdaterStrategyTest
    {
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

            IItemUpdaterStrategy genericUpdate = new LegendaryItemUpdaterStrategy(new LegendaryItemValidator());

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

            IItemUpdaterStrategy genericUpdate = new LegendaryItemUpdaterStrategy(new LegendaryItemValidator());

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }
    }

}

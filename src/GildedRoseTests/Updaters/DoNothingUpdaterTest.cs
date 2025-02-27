using Xunit;
using GildedRoseKata;
using GildedRoseKata.Updaters;

namespace GildedRoseTests.Updaters
{
    public class DoNothingUpdaterTest
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

            IUpdater genericUpdate = new DoNothingItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

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

            IUpdater genericUpdate = new DoNothingItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }


    }

}

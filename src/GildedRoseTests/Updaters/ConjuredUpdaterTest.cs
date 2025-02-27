using Xunit;
using GildedRoseKata;
using GildedRoseKata.Updaters;

namespace GildedRoseTests.Updaters
{
    public class ConjuredUpdaterTest
    {

        [Fact]
        public void In_Sellby_Date_Decreases_Quality_By_2()
        {
            //Arrange
            var expectedQuality = 8;
            var expectedSellin = 4;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 10,
                SellIn = 5
            };

            IUpdater genericUpdate = new ConjuredItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void In_Sellby_Date_And_Quality_Is_1_Quality_Does_Not_Go_Negative()
        {
            //Arrange
            var expectedQuality = 0;
            var expectedSellin = 4;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 1,
                SellIn = 5
            };

            IUpdater genericUpdate = new ConjuredItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Past_Sellby_Date_Decreases_Quality_By_4()
        {
            //Arrange
            var expectedQuality = 6;
            var expectedSellin = -2;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 10,
                SellIn = -1
            };

            IUpdater genericUpdate = new ConjuredItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Past_Sellby_Date_And_Quality_Is_3_Quality_Does_Not_Go_Negative()
        {
            //Arrange
            var expectedQuality = 0;
            var expectedSellin = -2;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 3,
                SellIn = -1
            };

            IUpdater genericUpdate = new ConjuredItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Past_Sellby_Date_And_Quality_Is_2_Quality_Does_Not_Go_Negative()
        {
            //Arrange
            var expectedQuality = 0;
            var expectedSellin = -2;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 2,
                SellIn = -1
            };

            IUpdater genericUpdate = new ConjuredItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Past_Sellby_Date_And_Quality_Is_1_Quality_Does_Not_Go_Negative()
        {
            //Arrange
            var expectedQuality = 0;
            var expectedSellin = -2;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 1,
                SellIn = -1
            };

            IUpdater genericUpdate = new ConjuredItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

    }

}

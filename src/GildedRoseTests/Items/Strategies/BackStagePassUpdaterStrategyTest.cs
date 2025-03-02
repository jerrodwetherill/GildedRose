using Xunit;
using GildedRoseKata.Items.Strategies;
using GildedRoseKata.Items.Entities;

namespace GildedRoseTests.Items.Strategies
{
    public class BackStagePassUpdaterStrategyTest
    {

        [Fact]
        public void Sellby_Date_Greater_Than_10_Days_Increases_Quality_By_1()
        {
            //Arrange
            var expectedQuality = 11;
            var expectedSellin = 11;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 10,
                SellIn = 12
            };

            IItemUpdaterStrategy genericUpdate = new BackStagePassItemUpdaterStrategy();

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Sellby_Date_Greater_Than_10_Days_Quality_Already_50_Quality_Does_Not_Increase()
        {
            //Arrange
            var expectedQuality = 50;
            var expectedSellin = 11;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 50,
                SellIn = 12
            };

            IItemUpdaterStrategy genericUpdate = new BackStagePassItemUpdaterStrategy();

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Sellby_Date_Less_Than_Or_Equals_10_Days_But_Greater_Than_5_Increases_Quality_By_2()
        {
            //Arrange
            var expectedQuality = 12;
            var expectedSellin = 9;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 10,
                SellIn = 10
            };

            IItemUpdaterStrategy genericUpdate = new BackStagePassItemUpdaterStrategy();

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Sellby_Date_Less_Than_Or_Equals_10_Days_But_Greater_Than_5_And_Quality_Already_49_Quality_Set_To_50()
        {
            //Arrange
            var expectedQuality = 50;
            var expectedSellin = 9;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 49,
                SellIn = 10
            };

            IItemUpdaterStrategy genericUpdate = new BackStagePassItemUpdaterStrategy();

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Sellby_Date_Less_Than_Or_Equals_5_Days_But_Greater_Than_0_Increases_Quality_By_3()
        {
            //Arrange
            var expectedQuality = 13;
            var expectedSellin = 0;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 10,
                SellIn = 1
            };

            IItemUpdaterStrategy genericUpdate = new BackStagePassItemUpdaterStrategy();

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Sellby_Date_Less_Than_Or_Equal_5_Days_But_Greater_Than_0_And_Quality_Already_49_Quality_Set_To_50()
        {
            //Arrange
            var expectedQuality = 50;
            var expectedSellin = 0;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 49,
                SellIn = 1
            };

            IItemUpdaterStrategy genericUpdate = new BackStagePassItemUpdaterStrategy();

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Sellby_Date_Equals_0_Quality_Set_To_0()
        {
            //Arrange
            var expectedQuality = 0;
            var expectedSellin = -1;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 10,
                SellIn = 0
            };

            IItemUpdaterStrategy genericUpdate = new BackStagePassItemUpdaterStrategy();

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Sellby_Date_Passed_Quality_Set_To_0()
        {
            //Arrange
            var expectedQuality = 0;
            var expectedSellin = -2;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 10,
                SellIn = -1
            };

            IItemUpdaterStrategy genericUpdate = new BackStagePassItemUpdaterStrategy();

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

    }

}

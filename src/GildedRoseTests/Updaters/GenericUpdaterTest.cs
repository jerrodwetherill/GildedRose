using Xunit;
using GildedRoseKata;
using GildedRoseKata.Updaters;

namespace GildedRoseTests.Updaters
{
    public class GenericUpdaterTest
    {

        [Fact]
        public void In_Sellby_Date_Decreases_Quality_By_1()
        {
            //Arrange
            var expectedQuality = 9;
            var expectedSellin = 4;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 10,
                SellIn = 5
            };

            IUpdater genericUpdate = new GenericItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }
      
        [Fact]
        public void In_Sellby_Date_And_Quality_Is_0_Quality_Does_Not_Go_Negative()
        {
            //Arrange
            var expectedQuality = 0;
            var expectedSellin = 4;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 0,
                SellIn = 5
            };

            IUpdater genericUpdate = new GenericItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Past_Sellby_Date_Decreases_Quality_By_2()
        {
            //Arrange
            var expectedQuality = 8;
            var expectedSellin = -2;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 10,
                SellIn = -1
            };

            IUpdater genericUpdate = new GenericItemUpdater(item);

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

            IUpdater genericUpdate = new GenericItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

    }

    public class BrieUpdaterTest
    {

        [Fact]
        public void In_Sellby_Date_Increases_Quality_By_1()
        {
            //Arrange
            var expectedQuality = 11;
            var expectedSellin = 4;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 10,
                SellIn = 5
            };

            IUpdater genericUpdate = new BrieItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void In_Sellby_Date_And_Quality_Is_50_Quality_Does_Not_Go_Over_50()
        {
            //Arrange
            var expectedQuality = 50;
            var expectedSellin = 4;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 50,
                SellIn = 5
            };

            IUpdater genericUpdate = new BrieItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Past_Sellby_Date_Increases_Quality_By_2()
        {
            //Arrange
            var expectedQuality = 12;
            var expectedSellin = -2;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 10,
                SellIn = -1
            };

            IUpdater genericUpdate = new BrieItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Past_Sellby_Date_And_Quality_Is_50_Quality_Does_Not_Go_Over_50()
        {
            //Arrange
            var expectedQuality = 50;
            var expectedSellin = -2;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 50,
                SellIn = -1
            };

            IUpdater genericUpdate = new BrieItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Past_Sellby_Date_And_Quality_Is_49_Quality_Does_Not_Go_Over_50()
        {
            //Arrange
            var expectedQuality = 50;
            var expectedSellin = -2;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 49,
                SellIn = -1
            };

            IUpdater genericUpdate = new BrieItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

    }


    public class BackStagePassUpdaterTest
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

            IUpdater genericUpdate = new BackStagePassItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Sellby_Date_Less_Than_10_Days_But_Greater_Than_5_Cut_Off_Increases_Quality_By_2()
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

            IUpdater genericUpdate = new BackStagePassItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

        [Fact]
        public void Sellby_Date_Less_Than_5_Days_But_Greater_Than_0_Cut_Off_Increases_Quality_By_3()
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

            IUpdater genericUpdate = new BackStagePassItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

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

            IUpdater genericUpdate = new BackStagePassItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

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

            IUpdater genericUpdate = new BackStagePassItemUpdater(item);

            //Act
            var result = genericUpdate.UpdateItem();

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }

    }

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

    }

}

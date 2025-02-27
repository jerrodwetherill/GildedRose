﻿using Xunit;
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

        [Fact]
        public void Past_Sellby_Date_And_Quality_Is_0_Quality_Does_Not_Go_Negative()
        {
            //Arrange
            var expectedQuality = 0;
            var expectedSellin = -2;

            var item = new Item()
            {
                Name = "test Item",
                Quality = 0,
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
}

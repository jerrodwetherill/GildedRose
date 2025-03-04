﻿using Xunit;
using GildedRoseKata.Inventory.Strategies;
using GildedRoseKata.Inventory.Entities;
using GildedRoseTests.Inventory.Validators;

namespace GildedRoseTests.Inventory.Strategies
{
    public class BrieUpdaterStrategyTest
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

            IItemUpdaterStrategy genericUpdate = new BrieItemUpdaterStrategy(new DefaultItemValidator());

            //Act
            var result = genericUpdate.UpdateQuality(item);

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

            IItemUpdaterStrategy genericUpdate = new BrieItemUpdaterStrategy(new DefaultItemValidator());

            //Act
            var result = genericUpdate.UpdateQuality(item);

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

            IItemUpdaterStrategy genericUpdate = new BrieItemUpdaterStrategy(new DefaultItemValidator());

            //Act
            var result = genericUpdate.UpdateQuality(item);

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

            IItemUpdaterStrategy genericUpdate = new BrieItemUpdaterStrategy(new DefaultItemValidator());

            //Act
            var result = genericUpdate.UpdateQuality(item);

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

            IItemUpdaterStrategy genericUpdate = new BrieItemUpdaterStrategy(new DefaultItemValidator());

            //Act
            var result = genericUpdate.UpdateQuality(item);

            //Assert
            Assert.Equal(expectedQuality, item.Quality);
            Assert.Equal(expectedSellin, item.SellIn);
        }
    }

}

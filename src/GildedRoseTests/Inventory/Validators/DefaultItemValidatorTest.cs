using GildedRoseKata.Inventory.Entities;
using System;
using Xunit;

namespace GildedRoseTests.Inventory.Validators
{
    public  class DefaultItemValidatorTest
    {
        [Fact]
        public void Quality_Set_To_Negative_UpdateQuality_Throws_Error()
        {
            //arrange
            var item = new Item()
            {
                Name = "test Item",
                Quality = -1,
                SellIn = 12
            };

            var defaultValidator = new DefaultItemValidator();
            
            //act
            
            //assert
            Assert.Throws<Exception>(() => defaultValidator.Validate(item));
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

            var defaultValidator = new DefaultItemValidator();

            //Assert
            var exception = Assert.Throws<Exception>(() => defaultValidator.Validate(item));
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

            var defaultValidator = new DefaultItemValidator();

            //Assert
            Assert.Throws<Exception>(() => defaultValidator.Validate(item));
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

            var defaultValidator = new DefaultItemValidator();

            //Assert
            var exception = Assert.Throws<Exception>(() => defaultValidator.Validate(item));
            Assert.Equal("Quality cannot be more than 50 for non legendary items", exception.Message);
        }
    }
}

using GildedRoseKata.Inventory.Entities;
using System;
using Xunit;

namespace GildedRoseTests.Inventory.Validators
{
    public class LegendaryItemValidatorTest
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

            var defaultValidator = new LegendaryItemValidator();

            //act

            //assert
            Assert.Throws<Exception>(() => defaultValidator.Validate(item));
        }

        [Fact]
        public void Quality_Set_To_Negative_UpdateQuality_Error_Message_Is_Set()
        {
            //Arrange
            var item = new Item()
            {
                Name = "test Item",
                Quality = -1,
                SellIn = 4
            };

            var defaultValidator = new LegendaryItemValidator();

            //Assert
            var exception = Assert.Throws<Exception>(() => defaultValidator.Validate(item));
            Assert.Equal("Quality cannot be negative", exception.Message);
        }

        [Fact]
        public void Quantity_Above_50_Does_Not_Throw_Error()
        {
            //Arrange
            var item = new Item()
            {
                Name = "test Item",
                Quality = 80,
                SellIn = 4
            };

            var defaultValidator = new LegendaryItemValidator();

            //Act
            defaultValidator.Validate(item);

            //Assert
        }

    }
}

using Xunit;
using GildedRoseKata.Inventory.Entities;
using GildedRoseKata.Inventory.Strategies;
using Moq;
using GildedRoseTests.Inventory.Validators;

namespace GildedRoseTests.Inventory.Strategies
{

    public class BaseItemUpdaterStrategyTest
    {
        private class TestItemUpdaterStrategyBase : ItemUpdaterStrategyBase
        {
            public TestItemUpdaterStrategyBase(IItemValidator validator) : base(validator)
            {

            }

            protected override void UpdateStrategyQuality(Item item)
            {

            }
        }

        [Fact]
        public void UpdateQuality_Calls_ItemValidator_Validate_Correct_Number_Of_Times()
        {
            //Arrange
            var _itemValidatorMock = new Mock<IItemValidator>();
            _itemValidatorMock.Setup(r => r.Validate(It.IsAny<Item>()));

            var strategy = new TestItemUpdaterStrategyBase(_itemValidatorMock.Object);
            
            var item = new Item()
            {
                Name = "test Item",
                Quality = 10,
                SellIn = 12
            };

            //Act
            strategy.UpdateQuality(item);

            //Assert
            _itemValidatorMock.Verify(r => r.Validate(It.IsAny<Item>()), Times.Exactly(1));
        }
    }
}

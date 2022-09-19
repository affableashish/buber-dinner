using BuberDinner.Domain.Entities;

namespace BuberDinner.Domain.UnitTests.Dinner
{
    public class DinnerTests
    {
        [Fact]
        public void Should_Calculate_Correct_Cost()
        {
            // ARRANGE
            var Dinner = new BuberDinner.Domain.Entities.Dinner() { Reason = "Crash", SomeUniqueThingInDb = "Something" };

            // ACT
            var cost = Dinner.GetCostOfDinner();

            // ASSERT
            Assert.Equal(2000, cost);
        }
    }
}
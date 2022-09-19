using BuberDinner.Application.Dinner.Command;
using BuberDinner.Application.Dinner.Query;
using BuberDinner.Web.Shared.Dinner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace BuberDinner.Application.IntegrationTests.Dinner
{
    [Collection(nameof(TestFixture))]
    public class DinnerTests
    {
        private readonly TestFixture _fixture;

        public DinnerTests(TestFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task Should_Return_All_Repair_Orders()
        {
            // ARRANGE
            var DinnerDto = new DinnerDto() { Reason = "Crash", SomeUniqueThingInDb = "Something" };
            await _fixture.SendAsync(new CreateDinnerCommand(DinnerDto));

            // ACT
            var DinnerQuery = new GetDinnersQuery();
            var result = await _fixture.SendAsync(DinnerQuery);

            // ASSERT
            result.ShouldNotBeNull();
            // Other Asserts
        }
    }
}

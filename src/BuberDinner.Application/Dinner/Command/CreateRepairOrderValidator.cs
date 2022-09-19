using FluentValidation;
using BuberDinner.Application.Common.Interfaces;
using BuberDinner.Web.Shared.Dinner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Dinner.Command
{
    //Server side validation
    public class CreateDinnerValidator : BuberDinner.Web.Shared.Dinner.CreateDinnerValidator
    {
        private readonly IInMemoryDatabase _db;
        public CreateDinnerValidator(IInMemoryDatabase db) : base()
        {
            _db = db;
        }

        public CreateDinnerValidator()
        {
            RuleFor(Dinner => Dinner.SomeUniqueThingInDb)
                .MustAsync(BeUniqueSomething)
                .WithMessage($"{nameof(DinnerDto.SomeUniqueThingInDb)} must be unique.");
        }

        public async Task<bool> BeUniqueSomething(DinnerDto Dinner, string someUniqueThingInDb, CancellationToken cancellationToken)
        {
            return (await _db.GetDinners())
                .Any(ro => ro.SomeUniqueThingInDb != someUniqueThingInDb);
        }
    }
}

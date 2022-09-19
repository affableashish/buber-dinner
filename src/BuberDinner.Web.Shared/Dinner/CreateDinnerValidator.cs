using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Web.Shared.Dinner
{
    // Client side validation
    public class CreateDinnerValidator : AbstractValidator<DinnerDto>
    {
        public CreateDinnerValidator()
        {
            RuleFor(p => p.SomeUniqueThingInDb)
                .NotEmpty();
        }
    }
}
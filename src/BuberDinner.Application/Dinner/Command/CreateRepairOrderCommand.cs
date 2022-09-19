using MediatR;
using BuberDinner.Application.Common.Interfaces;
using BuberDinner.Domain.Entities;
using BuberDinner.Domain.Events;
using BuberDinner.Web.Shared.Dinner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Dinner.Command
{
    public record CreateDinnerCommand : IRequest<int>
    {
        public CreateDinnerCommand(DinnerDto DinnerDto)
        {
            SomeUniqueThingInDb = DinnerDto.SomeUniqueThingInDb;
            Reason = DinnerDto.Reason;
        }

        public string SomeUniqueThingInDb { get; set; }
        public string Reason { get; set; }
    }

    public class CreateDinnerCommandHandler : IRequestHandler<CreateDinnerCommand, int>
    {
        private readonly IInMemoryDatabase _db;
        public CreateDinnerCommandHandler(IInMemoryDatabase db)
        {
            _db = db;
        }

        public async Task<int> Handle(CreateDinnerCommand request, CancellationToken cancellationToken)
        {
            var entity = new BuberDinner.Domain.Entities.Dinner
            {
                SomeUniqueThingInDb = request.SomeUniqueThingInDb,
                Reason = request.Reason
            };

            entity.AddDomainEvent(new DinnerCreatedEvent(entity));

            //_db.Dinners.Add(entity);

            // await _db.SaveChangesAsync(cancellationToken);

            return entity.OrderId;
        }
    }
}

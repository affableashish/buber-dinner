using MediatR;
using BuberDinner.Application.Common.Interfaces;
using BuberDinner.Web.Shared.Dinner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Dinner.Query
{
    public record GetDinnersQuery : IRequest<IEnumerable<DinnerDto>>
    {

    }

    public class GetDinnersQueryHandler : IRequestHandler<GetDinnersQuery, IEnumerable<DinnerDto>>
    {
        private readonly IInMemoryDatabase _db;
        public GetDinnersQueryHandler(IInMemoryDatabase db)
        {
            _db = db;
        }

        public async Task<IEnumerable<DinnerDto>> Handle(GetDinnersQuery request, CancellationToken cancellationToken)
        {
            var myDinners = (await _db.GetDinners())
                                        .Select(ro => new DinnerDto()
                                        {
                                            OrderId = ro.OrderId,
                                            SomeUniqueThingInDb = ro.SomeUniqueThingInDb,
                                            Reason = ro.Reason
                                        });
            return myDinners;
        }
    }
}

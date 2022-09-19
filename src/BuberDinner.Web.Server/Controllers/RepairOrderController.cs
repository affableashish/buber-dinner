using MediatR;
using Microsoft.AspNetCore.Mvc;
using BuberDinner.Application.Dinner.Command;
using BuberDinner.Application.Dinner.Query;
using BuberDinner.Web.Shared.Dinner;

namespace BuberDinner.Web.Server.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class DinnerController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<DinnerController> _logger;

        public DinnerController(ILogger<DinnerController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        // [ProducesResponseType(typeof(DinnerDto), StatusCodes.Status201Created)]
        public async Task<ActionResult<int>> Create(DinnerDto DinnerDto)
        {
            var DinnerCommand = new CreateDinnerCommand(DinnerDto);
            return await _mediator.Send(DinnerCommand);
        }

        [HttpGet]
        // [ProducesResponseType(typeof(IEnumerable<DinnerDto>), StatusCodes.Status200OK)]
        // [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IEnumerable<DinnerDto>> Get()
        {
            var DinnersQuery = new GetDinnersQuery();
            return await _mediator.Send(DinnersQuery);
        }
    }
}

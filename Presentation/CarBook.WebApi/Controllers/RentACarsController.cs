using CarBook.Application.Features.Mediator.Queries.RentACarQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentACarsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RentACarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetRentACarsByLocation(int locationId,bool isAvailable)
        {
            GetRentACarQuery query = new GetRentACarQuery()
            {
                IsAvailable = isAvailable,
                LocationId = locationId
            };
            var values = await _mediator.Send(query);
            return Ok(values);
        }
    }
}

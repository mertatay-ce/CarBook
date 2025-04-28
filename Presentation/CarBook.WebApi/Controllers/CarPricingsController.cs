using CarBook.Application.Features.Mediator.Commands.CarPricingCommands;
using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CarPricingsList()
        {
            var values = await _mediator.Send(new GetCarPricingQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarPricingById(int id)
        {
            var value = await _mediator.Send(new GetCarPricingByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCarPricing(CreateCarPricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Car pricing information has been created");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCarPricing(UpdateCarPricingCommand command)
        {
            await _mediator.Send(command);
            return Ok("Car pricing information has been updated");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCarPricing(int id)
        {
            await _mediator.Send(new RemoveCarPricingCommand(id));
            return Ok("Car pricing information has been deleted");
        }

        [HttpGet("GetCarPricingsWithCars")]
        public async Task<IActionResult> GetCarPricingsWithCars()
        {
            var values = await _mediator.Send(new GetCarPricingsWithCarsQuery());
            return Ok(values);
        }
    }
}

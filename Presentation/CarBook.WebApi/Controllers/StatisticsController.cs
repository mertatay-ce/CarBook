using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetCarCount")]
        public async Task<IActionResult> GetCarCount()
        {
            var count = await _mediator.Send(new GetCarCountQuery());
            return Ok(count);
        }
        [HttpGet("GetAutomaticCarCount")]
        public async Task<IActionResult> GetAutomaticCarCount()
        {
            var count = await _mediator.Send(new GetAutomaticCarCountQuery());
            return Ok(count);
        }
        
        [HttpGet("GetLocationCount")]
        public async Task<IActionResult> GetLocationCount()
        {
            var count = await _mediator.Send(new GetLocationCountQuery());
            return Ok(count);
        }
        [HttpGet("GetAuthorCount")]
        public async Task<IActionResult> GetAuthorCount()
        {
            var count = await _mediator.Send(new GetAuthorCountQuery());
            return Ok(count);
        }
        
        [HttpGet("GetBlogCount")]
        public async Task<IActionResult> GetBlogCount()
        {
            var count = await _mediator.Send(new GetBlogCountQuery());
            return Ok(count);
        }
        [HttpGet("GetBrandByMaxCarCapacity")]
        public async Task<IActionResult> GetBrandByMaxCarCapacity()
        {
            var count = await _mediator.Send(new GetBrandByMaxCarCapacityQuery());
            return Ok(count);
        }
        [HttpGet("GetCarCountByMaxKmLowerThanThousand")]
        public async Task<IActionResult> GetCarCountByMaxKmLowerThanThousand()
        {
            var count = await _mediator.Send(new GetCarCountByMaxKmLowerThanThousandQuery());
            return Ok(count);
        }
        [HttpGet("GetCarCountIsFueledByGasolineOrDiesel")]
        public async Task<IActionResult> GetCarCountIsFueledByGasolineOrDiesel()
        {
            var count = await _mediator.Send(new GetCarCountIsFueledByGasolineOrDieselQuery());
            return Ok(count);
        }
        [HttpGet("GetBrandCount")]
        public async Task<IActionResult> GetBrandCount()
        {
            var count = await _mediator.Send(new GetBrandCountQuery());
            return Ok(count);
        }
        [HttpGet("GetBlogTitleByMaxCommentCount")]
        public async Task<IActionResult> GetBlogTitleByMaxCommentCount()
        {
            var count = await _mediator.Send(new GetBlogTitleByMaxCommentCountQuery());
            return Ok(count);
        }
        
        [HttpGet("GetAverageTotalFeeDaily")]
        public async Task<IActionResult> GetAverageTotalFeeDaily()
        {
            var count = await _mediator.Send(new GetAverageTotalFeeDailyQuery());
            return Ok(count);
        }
        [HttpGet("GetAverageTotalFeeWeekly")]
        public async Task<IActionResult> GetAverageTotalFeeWeekly()
        {
            var count = await _mediator.Send(new GetAverageTotalFeeWeeklyQuery());
            return Ok(count);
        }
        [HttpGet("GetAverageTotalFeeMonthly")]
        public async Task<IActionResult> GetAverageTotalFeeMonthly()
        {
            var count = await _mediator.Send(new GetAverageTotalFeeMonthlyQuery());
            return Ok(count);
        }
        [HttpGet("GetCarBrandAndModelByRentPriceDailyMax")]
        public async Task<IActionResult> GetCarBrandAndModelByRentPriceDailyMax()
        {
            var count = await _mediator.Send(new GetCarBrandAndModelByRentPriceDailyMaxQuery());
            return Ok(count);
        }
        [HttpGet("GetCarBrandAndModelByRentPriceDailyMin")]
        public async Task<IActionResult> GetCarBrandAndModelByRentPriceDailyMin()
        {
            var count = await _mediator.Send(new GetCarBrandAndModelByRentPriceDailyMinQuery());
            return Ok(count);
        }
        [HttpGet("GetCarCountIsFueledByDiesel")]
        public async Task<IActionResult> GetCarCountIsFueledByDiesel()
        {
            var count = await _mediator.Send(new GetCarCountIsFueledByDieselQuery());
            return Ok(count);
        }
        [HttpGet("GetCarCountIsFueledByElectric")]
        public async Task<IActionResult> GetCarCountIsFueledByElectric()
        {
            var count = await _mediator.Send(new GetCarCountIsFueledByElectricQuery());
            return Ok(count);
        }
    }
}

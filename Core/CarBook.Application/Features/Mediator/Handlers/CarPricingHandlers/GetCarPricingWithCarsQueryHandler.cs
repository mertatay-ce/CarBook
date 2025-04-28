using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers;

public class GetCarPricingWithCarsQueryHandler: IRequestHandler<GetCarPricingsWithCarsQuery, List<GetCarPricingWithCarsQueryResult>>
{
    private readonly ICarPricingRepository _repository;

    public GetCarPricingWithCarsQueryHandler(ICarPricingRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarPricingWithCarsQueryResult>> Handle(GetCarPricingsWithCarsQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetCarPricingsWithCars();
        return values.Select(x => new GetCarPricingWithCarsQueryResult
        {
            Amount = x.Amount,
            CarPricingId = x.CarPricingId,
            CarBrandName = x.Car.Brand.Name,
            CoverImageUrl = x.Car.CoverImageUrl,
            PricingName = x.Pricing.Name,
            Model = x.Car.Model,
        }).ToList();
    }
}
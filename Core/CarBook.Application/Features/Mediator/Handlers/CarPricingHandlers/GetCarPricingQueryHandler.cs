using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers;

public class GetCarPricingQueryHandler : IRequestHandler<GetCarPricingQuery, List<GetCarPricingQueryResult>>
{
    private readonly IRepository<CarPricing> _repository;

    public GetCarPricingQueryHandler(IRepository<CarPricing> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarPricingQueryResult>> Handle(GetCarPricingQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetCarPricingQueryResult
        {
            CarId = x.CarId,
            CarPricingId = x.CarPricingId,
            Amount = x.Amount,
            PricingId = x.PricingId
        }).ToList();
    }
}
using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers;

public class GetCarPricingByIdQueryHandler : IRequestHandler<GetCarPricingByIdQuery,GetCarPricingByIdQueryResult>
{
    private readonly IRepository<CarPricing> _repository;

    public GetCarPricingByIdQueryHandler(IRepository<CarPricing> repository)
    {
        _repository = repository;
    }

    public async Task<GetCarPricingByIdQueryResult> Handle(GetCarPricingByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetCarPricingByIdQueryResult()
        {
            CarPricingId = value.CarPricingId,
            CarId = value.CarId,
            PricingId = value.PricingId,
            Amount = value.Amount,
        };
    }
}
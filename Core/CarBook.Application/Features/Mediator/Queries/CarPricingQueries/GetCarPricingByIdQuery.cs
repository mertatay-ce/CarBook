using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.CarPricingQueries;

public class GetCarPricingByIdQuery : IRequest<GetCarPricingByIdQueryResult>
{
    public int Id { get; set; }

    public GetCarPricingByIdQuery(int ıd)
    {
        Id = ıd;
    }
}
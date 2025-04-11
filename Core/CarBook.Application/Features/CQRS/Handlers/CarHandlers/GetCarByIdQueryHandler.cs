using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarByIdQueryHandler
{
    private readonly IRepository<Car> _repository;

    public GetCarByIdQueryHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
    {
        var value = await _repository.GetByIdAsync(query.Id);
        return new GetCarByIdQueryResult
        {
            CarId = value.CarId,
            BrandId = value.BrandId,
            ImageUrl = value.ImageUrl,
            CoverImageUrl = value.CoverImageUrl,
            Mileage = value.Mileage,
            Luggage = value.Luggage,
            Seats = value.Seats,
            Fuel = value.Fuel,
            Model = value.Model,
            Transmission = value.Transmission
        };
    }
}
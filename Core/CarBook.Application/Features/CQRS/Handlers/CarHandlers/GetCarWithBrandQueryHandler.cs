using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarWithBrandQueryHandler
{
    private readonly ICarRepository _repository;

    public GetCarWithBrandQueryHandler(ICarRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarWithBrandQueryResult>> Handle()
    {
        var values = await _repository.GetCarsListWithBrands();
        return values.Select(x => new GetCarWithBrandQueryResult
        {
            CarId = x.CarId,
            BrandId = x.BrandId,
            BrandName = x.Brand.Name,
            ImageUrl = x.ImageUrl,
            CoverImageUrl = x.CoverImageUrl,
            Mileage = x.Mileage,
            Luggage = x.Luggage,
            Seats = x.Seats,
            Fuel = x.Fuel,
            Model = x.Model,
            Transmission = x.Transmission
        }).ToList();
    }
}
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces.CarInterfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class GetLast5CarsWithBrandQueryHandler
{
    private readonly ICarRepository _repository;

    public GetLast5CarsWithBrandQueryHandler(ICarRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<List<GetLast5CarsWithBrandQueryResult>> Handle()
    {
        var values = await _repository.GetLast5CarsWithBrands();
        return values.Select(x =>new GetLast5CarsWithBrandQueryResult
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
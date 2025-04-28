using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarPricingInterfaces;

public interface ICarPricingRepository
{
    public Task<List<CarPricing>> GetCarPricingsWithCars();
}
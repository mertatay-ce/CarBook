using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.CarPricingRepositories;

public class CarPricingRepository : ICarPricingRepository
{
    private readonly CarBookContext _context;

    public CarPricingRepository(CarBookContext context)
    {
        _context = context;
    }

    public async Task<List<CarPricing>> GetCarPricingsWithCars()
    {
        var pricings = await _context.CarPricings.Include(x => x.Car).ThenInclude(x => x.Brand).Include(z => z.Pricing)
            .ToListAsync();
        return pricings;
    }

    
}
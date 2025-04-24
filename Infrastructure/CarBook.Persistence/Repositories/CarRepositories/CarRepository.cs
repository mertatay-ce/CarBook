using CarBook.Application.Interfaces.CarInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.CarRepositories;

public class CarRepository : ICarRepository
{
    private readonly CarBookContext _context;

    public CarRepository(CarBookContext context)
    {
        _context = context;
    }

    public async Task<List<Car>> GetCarsListWithBrands()
    {
        var cars = await _context.Cars.Include(x => x.Brand).ToListAsync();
        return cars;
    }

    public async Task<List<Car>> GetLast5CarsWithBrands()
    {
        var cars = await _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.CarId).Take(5).ToListAsync();
        return cars;
    }
}
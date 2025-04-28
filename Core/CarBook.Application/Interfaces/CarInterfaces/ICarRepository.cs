using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarInterfaces;

public interface ICarRepository
{
    public Task<List<Car>> GetCarsListWithBrands();
    public Task<List<Car>> GetLast5CarsWithBrands();
    
  
}
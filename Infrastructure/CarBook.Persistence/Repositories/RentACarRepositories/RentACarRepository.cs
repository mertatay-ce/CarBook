using System.Linq.Expressions;
using CarBook.Application.Interfaces.RentACarInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.RentACarRepositories;

public class RentACarRepository : IRentACarRepository
{
    private readonly CarBookContext  _context;

    public RentACarRepository(CarBookContext context)
    {
        _context = context;
    }

    public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> predicate)
    {
        var values = await _context.RentACars.Where(predicate).Include(x=> x.RentedCar).ThenInclude(y=> y.Brand).ToListAsync();
        return values;
    }
}
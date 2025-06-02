using CarBook.Application.Interfaces.StatisticsInterfaces;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.StatisticsRepositories;

public class StatisticsRepository : IStatisticsRepository
{
    private readonly CarBookContext _context;

    public StatisticsRepository(CarBookContext context)
    {
        _context = context;
    }

    public int GetCarCount()
    {
        var count =  _context.Cars.Count();
        return count;
    }

    public int GetLocationCount()
    {
        var count =  _context.Locations.Count();
        return count;
    }

    public int GetAuthorCount()
    {
        var count =  _context.Authors.Count();
        return count;
    }

    public int GetBlogCount()
    {
        var count =  _context.Blogs.Count();
        return count;
    }

    public int GetBrandCount()
    {
        var count =  _context.Brands.Count();
        return count;
    }

    public decimal GetAverageTotalFeeDaily()
    {
        var id = _context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.PricingId).First();
        var averageDailyFee = _context.CarPricings.Where(x => x.PricingId == id).Average(y => y.Amount);
        return averageDailyFee;
    }

    public decimal GetAverageTotalFeeWeekly()
    {
        var id = _context.Pricings.Where(x => x.Name == "Haftalık").Select(y => y.PricingId).First();
        var averageWeeklyFee = _context.CarPricings.Where(x => x.PricingId == id).Average(y => y.Amount);
        return averageWeeklyFee;
    }

    public decimal GetAverageTotalFeeMonthly()
    {
        var id = _context.Pricings.Where(x => x.Name == "Aylık").Select(y => y.PricingId).First();
        var averageMonthlyFee = _context.CarPricings.Where(x => x.PricingId == id).Average(y => y.Amount);
        return averageMonthlyFee;
    }
    
    public int GetAutomaticCarCount()
    {
        var automaticCarCount= _context.Cars.Count(x => x.Transmission == "Otomatik");
        return automaticCarCount;
    }

    public string GetBrandByMaxCarCapacity()
    {
        //SELECT b.Name, COUNT(*) as 'ToplamArac' FROM  Cars INNER JOIN Brands b On b.BrandId = Cars.BrandId GROUP BY b.Name ORDER BY 'ToplamArac' desc
        var values = _context.Cars.GroupBy(x=> x.BrandId)
                    .Select(y=> new
                    {
                        BrandId = y.Key,
                        Count = y.Count()
                    }).OrderByDescending(z=>z.Count).Take(1).FirstOrDefault(); 
        var brandName = _context.Brands.Where(x => x.BrandId == values.BrandId).Select(x => x.Name).First();
       return brandName;
    }

    public string GetBlogTitleByMaxCommentCount()
    {
        var values = _context.Comments.GroupBy(x=> x.BlogId)
            .Select(y=> new
            {
                BlogId = y.Key,
                Count = y.Count()
            }).OrderByDescending(z=>z.Count).Take(1).FirstOrDefault(); 
        var blogTitle = _context.Blogs.Where(x => x.BlogId == values.BlogId).Select(x => x.Title).First();
        return blogTitle;
    }

    public int GetCarCountByMaxKmLowerThanThousand()
    {
        var value = _context.Cars.Count(x => x.Mileage < 1000);
        return value;;
    }

    public int GetCarCountIsFueledByGasolineOrDiesel()
    {
        var value = _context.Cars.Count(x => x.Fuel == "Benzinli" || x.Fuel == "Dizel");
        return value;
    }

    public int GetCarCountIsFueledByDiesel()
    {
        var value = _context.Cars.Count(x => x.Fuel == "Dizel");
        return value;
    }

    public int GetCarCountIsFueledByElectric()
    {
        var value = _context.Cars.Count(x => x.Fuel == "Elektrik");
        return value;
    }

    public string GetCarBrandAndModelByRentPriceDailyMax()
    {
        var id = _context.Pricings.Where(x=> x.Name =="Günlük").Select(y => y.PricingId).First();
        var carId = _context.CarPricings.Where(x=> x.PricingId == id).OrderByDescending(x=> x.Amount).Select(x=> x.CarId).First();
        var brandId = _context.Cars.Where(x=> x.CarId == carId).Select(x=>x.BrandId).First();
        var brandName = _context.Brands.Where(x=> x.BrandId == brandId).Select(y=> y.Name).First();
        var carName =  _context.Cars.Where(x=> x.CarId == carId).Select(x=>x.Model).First();
        return "" + brandName + " " + carName;
    }

    public string GetCarBrandAndModelByRentPriceDailyMin()
    {
        var id = _context.Pricings.Where(x=> x.Name =="Günlük").Select(y => y.PricingId).First();
        var carId = _context.CarPricings.Where(x=> x.PricingId == id).OrderBy(x=> x.Amount).Select(x=> x.CarId).First();
        var brandId = _context.Cars.Where(x=> x.CarId == carId).Select(x=>x.BrandId).First();
        var brandName = _context.Brands.Where(x=> x.BrandId == brandId).Select(y=> y.Name).First();
        var carName =  _context.Cars.Where(x=> x.CarId == carId).Select(x=>x.Model).First();
        return "" + brandName + " " + carName;
    }
}
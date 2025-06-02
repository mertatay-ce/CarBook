namespace CarBook.Application.Interfaces.StatisticsInterfaces;

public interface IStatisticsRepository
{
    int GetCarCount();
    int GetLocationCount();
    int GetAuthorCount();
    int GetBlogCount();
    int GetBrandCount();
    decimal GetAverageTotalFeeDaily();
    decimal GetAverageTotalFeeWeekly();
    decimal GetAverageTotalFeeMonthly();
    int GetAutomaticCarCount();
    string GetBrandByMaxCarCapacity();
    string GetBlogTitleByMaxCommentCount();

    int GetCarCountByMaxKmLowerThanThousand();

    int GetCarCountIsFueledByGasolineOrDiesel();
    int GetCarCountIsFueledByDiesel();
    int GetCarCountIsFueledByElectric();
    string GetCarBrandAndModelByRentPriceDailyMax();
    string GetCarBrandAndModelByRentPriceDailyMin();
}
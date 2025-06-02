namespace CarBook.Dto.StatisticsDtos;

public class ResultStatisticsDto
{
    public int AuthorCount { get; set; }
    public int AutomaticCarCount { get; set; }
    public decimal AverageDailyFee { get; set; }
    public decimal AverageMonthlyFee { get; set; }
    public decimal AverageWeeklyFee { get; set; }
    public int BlogCount { get; set; }
    
    public string BlogTitle { get; set; }
    public string BrandName { get; set; }
    
    public int BrandCount { get; set; }
    public string CarBrandAndModelByRentPriceDailyMin { get; set; }
    public string CarBrandAndModelByRentPriceDailyMax { get; set; }
    public int CarCountMaxKmLowerThan1000 { get; set; }
    public int CarCountIsFueledByDiesel { get; set; }
    public int CarCountIsFueledByElectric { get; set; }
    public int CarCountIsFueledByGasolineOrDiesel { get; set; }
    public int CarCount { get; set; }
    public int LocationCount { get; set; }
}
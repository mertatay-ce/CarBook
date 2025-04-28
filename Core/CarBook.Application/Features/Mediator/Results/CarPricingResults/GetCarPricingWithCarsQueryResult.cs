namespace CarBook.Application.Features.Mediator.Results.CarPricingResults;

public class GetCarPricingWithCarsQueryResult
{
    public int CarPricingId { get; set; }
    
    public decimal Amount { get; set; }

    public string PricingName { get; set; }
    public string CarBrandName { get; set; }
    public string Model { get; set; }
    public string CoverImageUrl { get; set; }
    
}
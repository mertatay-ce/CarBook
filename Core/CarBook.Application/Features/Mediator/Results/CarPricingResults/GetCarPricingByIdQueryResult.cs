namespace CarBook.Application.Features.Mediator.Results.CarPricingResults;

public class GetCarPricingByIdQueryResult
{
    public int CarPricingId { get; set; }
    public int CarId { get; set; }
    public int PricingId { get; set; }
    public decimal Amount { get; set; }
}
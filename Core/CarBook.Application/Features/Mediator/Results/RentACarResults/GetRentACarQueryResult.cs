namespace CarBook.Application.Features.Mediator.Results.RentACarResults;

public class GetRentACarQueryResult
{
    public int CarId { get; set; }
    public decimal Amount { get; set; }
    public string PricingName { get; set; }
    public string CarBrandName { get; set; }
    public string Model { get; set; }
    public string CoverImageUrl { get; set; }
}
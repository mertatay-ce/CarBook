namespace CarBook.Dto.CarDtos;

public class CreateCarDto
{
    public int BrandId { get; set; }
    public string Model { get; set; }
    public string CoverImageUrl { get; set; }
    public int Mileage { get; set; }
    public string Transmission { get; set; }
    public byte Seats { get; set; }
    public byte Luggage { get; set; }
    public string Fuel { get; set; }
    public string ImageUrl { get; set; }
}
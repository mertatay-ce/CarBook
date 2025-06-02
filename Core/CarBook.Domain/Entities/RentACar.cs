namespace CarBook.Domain.Entities;

public class RentACar
{
    public int RentACarId { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
    public int CarId { get; set; }
    public Car RentedCar { get; set; }
    public bool IsAvailable { get; set; }
}
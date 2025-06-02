using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBook.Domain.Entities;

public class RentACarProcess
{
    public int RentACarProcessId { get; set; }
    public int CarId { get; set; }
    public Car Car { get; set; }
    public string PickUpLocation { get; set; }
    public string DropOffLocation { get; set; }
    
    [Column(TypeName = "date")]
    public DateOnly PickUpDate { get; set; }
    
    [Column(TypeName = "date")]
    public DateOnly DropOffDate { get; set; }
    
    [DataType(DataType.Time)]
    public TimeOnly PickUpTime { get; set; }
     
    [DataType(DataType.Time)]
    public TimeOnly DropOffTime { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public string PickUpDescription { get; set; }
    public string DropOffDescription { get; set; }
    public decimal TotalPrice  { get; set; }
}
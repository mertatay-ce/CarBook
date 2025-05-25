namespace CarBook.Dto.FooterAddressDtos;

public class UpdateFooterAddressDto
{
    public int footerAddressId { get; set; }
    public string description { get; set; }
    public string address { get; set; }
    public string phoneNumber { get; set; }
    public string email { get; set; }
}
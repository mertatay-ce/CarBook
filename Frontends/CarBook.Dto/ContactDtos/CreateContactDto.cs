namespace CarBook.Dto.ContactDtos;

public class CreateContactDto
{
    public string name { get; set; }
    public string email { get; set; }
    public string subject { get; set; }
    public string message { get; set; }
    public DateTime sendDate { get; set; }
}
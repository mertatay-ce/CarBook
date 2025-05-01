namespace CarBook.Dto.BlogDtos;

public class ResultGetBlogByIdDto
{
    public int blogId { get; set; }
    public string title { get; set; }
    public int authorId { get; set; }
    public string coverImageUrl { get; set; }
    public string createdDate { get; set; }
    public int categoryId { get; set; }
    public string description { get; set; }
}
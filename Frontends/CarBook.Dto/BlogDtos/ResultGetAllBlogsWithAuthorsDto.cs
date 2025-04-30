namespace CarBook.Dto.BlogDtos;

public class ResultGetAllBlogsWithAuthorsDto
{
    public int blogId { get; set; }
    public string title { get; set; }
    public int authorId { get; set; }
    public string coverImageUrl { get; set; }
    public DateTime createdDate { get; set; }
    public int categoryId { get; set; }
    public string authorName { get; set; }
    public string description { get; set; }
}
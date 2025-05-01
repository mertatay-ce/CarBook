namespace CarBook.Dto.BlogDtos;

public class ResultGetAuthorByBlogIdDto
{
    public int blogId { get; set; }
    public int authorId { get; set; }
    public string authorName { get; set; }
    public string authorDescription { get; set; }
    public string authorImageUrl { get; set; }
}
namespace CarBook.Dto.TagCloudDtos;

public class GetTagCloudByBlogIdDto
{
    public int TagCloudId { get; set; }
    public string TagCloudName { get; set; }
    public int BlogId { get; set; }
}
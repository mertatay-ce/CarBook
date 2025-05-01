namespace CarBook.Domain.Entities;

public class TagCloud
{
    public int TagCloudId { get; set; }
    public string TagCloudName { get; set; }
    public int BlogId { get; set; }
    public Blog Blog { get; set; }
    
}
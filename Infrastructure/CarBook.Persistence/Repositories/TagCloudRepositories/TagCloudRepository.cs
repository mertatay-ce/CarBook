using CarBook.Application.Interfaces.TagCloudInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.TagCloudRepositories;

public class TagCloudRepository : ITagCloudRepository
{
    private readonly CarBookContext _context;

    public TagCloudRepository(CarBookContext context)
    {
        _context = context;
    }

   

    public async Task<List<TagCloud>> GetTagCloudsByBlogId(int id)
    {
        var tags = await _context.TagClouds.Include(x => x.Blog).Where(x => x.BlogId == id).ToListAsync();
        return tags;
    }
}
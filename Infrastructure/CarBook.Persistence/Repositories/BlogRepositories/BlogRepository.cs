using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.BlogRepositories;

public class BlogRepository : IBlogRepository
{
    private readonly CarBookContext _context;

    public BlogRepository(CarBookContext context)
    {
        _context = context;
    }

    public async Task<List<Blog>> GetLast3BlogsWithAuthors()
    {
        var values = await _context.Blogs.Include(x => x.Author).OrderByDescending(x=>x.BlogId).Take(3).ToListAsync();
        return values;
    }

    public async Task<List<Blog>> GetAllBlogsWithAuthors()
    {
        var blogs = await _context.Blogs.Include(x => x.Author).ToListAsync();
        return blogs;
    }

    public async Task<Blog> GetAuthorByBlogId(int id)
    {
        var blog = await _context.Blogs.Include(x => x.Author).Where(x => x.BlogId == id).FirstAsync();
        return blog;
    }
}
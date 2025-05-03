using CarBook.Application.Features.RepositoryPattern;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;

namespace CarBook.Persistence.Repositories.CommentRepositories;

public class CommentRepository<T> : IGenericRepository<Comment>
{
    private readonly CarBookContext _context;

    public CommentRepository(CarBookContext context)
    {
        _context = context;
    }

    public List<Comment> GetAll()
    {
         var values = _context.Comments.Select(x=> new Comment()
         {
             BlogId = x.BlogId,
             CommentId = x.CommentId,
             CreatedDate = x.CreatedDate,
             Description = x.Description,
             Name = x.Name
         }).ToList();
         return values;
    }

    public Comment GetById(int id)
    {
        var value = _context.Comments.Find(id);
        return value;
    }

    public void Create(Comment entity)
    {
        _context.Comments.Add(entity);
        _context.SaveChanges();
    }

    public void Update(Comment entity)
    {
        _context.Comments.Update(entity);
        _context.SaveChanges();
    }

    public void Remove(Comment entity)
    {
        var value = _context.Comments.Find(entity.CommentId);
        _context.Comments.Remove(value);
        _context.SaveChanges();
    }
}
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers;

public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
{
    private readonly IRepository<Blog> _repository;

    public GetBlogByIdQueryHandler(IRepository<Blog> repository)
    {
        _repository = repository;
    }

    public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetBlogByIdQueryResult
        {
            AuthorId = value.AuthorId,
            Title = value.Title,
            BlogId = value.BlogId,
            CreatedDate = value.CreatedDate,
            CategoryId = value.CategoryId,
            CoverImageUrl = value.CoverImageUrl
            
        };
    }
}
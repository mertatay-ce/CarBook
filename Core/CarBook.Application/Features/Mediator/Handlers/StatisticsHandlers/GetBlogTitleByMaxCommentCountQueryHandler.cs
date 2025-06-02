using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetBlogTitleByMaxCommentCountQueryHandler :  IRequestHandler<GetBlogTitleByMaxCommentCountQuery,GetBlogTitleByMaxCommentCountQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetBlogTitleByMaxCommentCountQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }

    public Task<GetBlogTitleByMaxCommentCountQueryResult> Handle(GetBlogTitleByMaxCommentCountQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetBlogTitleByMaxCommentCount();
        return Task.FromResult(new GetBlogTitleByMaxCommentCountQueryResult()
        {
            BlogTitle = value 
        });
    }
}
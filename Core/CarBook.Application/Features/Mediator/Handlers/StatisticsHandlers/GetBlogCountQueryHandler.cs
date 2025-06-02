using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetBlogCountQueryHandler : IRequestHandler<GetBlogCountQuery, GetBlogCountQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetBlogCountQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }

    public Task<GetBlogCountQueryResult> Handle(GetBlogCountQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetBlogCount();
        return Task.FromResult(new GetBlogCountQueryResult()
        {
            BlogCount = value
        });
    }
}
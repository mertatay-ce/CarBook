using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetAuthorCountQueryHandler :  IRequestHandler<GetAuthorCountQuery, GetAuthorCountQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetAuthorCountQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }


    public Task<GetAuthorCountQueryResult> Handle(GetAuthorCountQuery request, CancellationToken cancellationToken)
    {
        var count = _repository.GetAuthorCount();
        return Task.FromResult(new GetAuthorCountQueryResult()
        {
            AuthorCount = count
        });
    }
}
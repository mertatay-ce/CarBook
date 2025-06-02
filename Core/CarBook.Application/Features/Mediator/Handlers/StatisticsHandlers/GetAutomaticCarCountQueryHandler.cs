using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetAutomaticCarCountQueryHandler : IRequestHandler<GetAutomaticCarCountQuery,GetAutomaticCarCountQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetAutomaticCarCountQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }

    public Task<GetAutomaticCarCountQueryResult> Handle(GetAutomaticCarCountQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetAutomaticCarCount();
        return Task.FromResult(new  GetAutomaticCarCountQueryResult()
        {
            AutomaticCarCount = value
        });
    }
}
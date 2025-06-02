using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetCarCountQueryHandler : IRequestHandler<GetCarCountQuery, GetCarCountQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetCarCountQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }

    public Task<GetCarCountQueryResult> Handle(GetCarCountQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetCarCount();
        return Task.FromResult(new GetCarCountQueryResult()
        {
            CarCount = value
        });
    }
}
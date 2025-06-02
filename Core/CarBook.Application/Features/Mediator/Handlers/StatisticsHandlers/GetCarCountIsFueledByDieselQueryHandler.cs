using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetCarCountIsFueledByDieselQueryHandler :  IRequestHandler<GetCarCountIsFueledByDieselQuery,GetCarCountIsFueledByDieselQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetCarCountIsFueledByDieselQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }

    public Task<GetCarCountIsFueledByDieselQueryResult> Handle(GetCarCountIsFueledByDieselQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetCarCountIsFueledByDiesel();
        return Task.FromResult(new GetCarCountIsFueledByDieselQueryResult()
        {
            CarCountIsFueledByDiesel = value
        });
    }
}
using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetCarCountIsFueledByGasolineOrDieselQueryHandler :  IRequestHandler<GetCarCountIsFueledByGasolineOrDieselQuery,GetCarCountIsFueledByGasolineOrDieselQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetCarCountIsFueledByGasolineOrDieselQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }

    public Task<GetCarCountIsFueledByGasolineOrDieselQueryResult> Handle(GetCarCountIsFueledByGasolineOrDieselQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetCarCountIsFueledByGasolineOrDiesel();
        return Task.FromResult(new GetCarCountIsFueledByGasolineOrDieselQueryResult()
        {
            CarCountIsFueledByGasolineOrDiesel = value
        });
    }
}
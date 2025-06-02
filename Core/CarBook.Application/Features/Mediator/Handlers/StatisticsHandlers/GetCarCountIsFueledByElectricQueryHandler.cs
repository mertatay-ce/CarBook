using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetCarCountIsFueledByElectricQueryHandler : IRequestHandler<GetCarCountIsFueledByElectricQuery,GetCarCountIsFueledByElectricQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetCarCountIsFueledByElectricQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }

    public Task<GetCarCountIsFueledByElectricQueryResult> Handle(GetCarCountIsFueledByElectricQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetCarCountIsFueledByElectric();
        return Task.FromResult(new GetCarCountIsFueledByElectricQueryResult()
        {
            CarCountIsFueledByElectric = value
        });
    }
}
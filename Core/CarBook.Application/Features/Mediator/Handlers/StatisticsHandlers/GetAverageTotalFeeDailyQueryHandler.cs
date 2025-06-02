using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetAverageTotalFeeDailyQueryHandler : IRequestHandler<GetAverageTotalFeeDailyQuery, GetAverageTotalFeeDailyQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetAverageTotalFeeDailyQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }

    public Task<GetAverageTotalFeeDailyQueryResult> Handle(GetAverageTotalFeeDailyQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetAverageTotalFeeDaily();
        return Task.FromResult(new GetAverageTotalFeeDailyQueryResult()
        {
            AverageDailyFee = value
        });
    }
}
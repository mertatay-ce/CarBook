using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetAverageTotalFeeWeeklyQueryHandler :  IRequestHandler<GetAverageTotalFeeWeeklyQuery, GetAverageTotalFeeWeeklyQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetAverageTotalFeeWeeklyQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }

    public Task<GetAverageTotalFeeWeeklyQueryResult> Handle(GetAverageTotalFeeWeeklyQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetAverageTotalFeeWeekly();
        return Task.FromResult(new GetAverageTotalFeeWeeklyQueryResult()
        {
            AverageWeeklyFee = value
        });
    }
}
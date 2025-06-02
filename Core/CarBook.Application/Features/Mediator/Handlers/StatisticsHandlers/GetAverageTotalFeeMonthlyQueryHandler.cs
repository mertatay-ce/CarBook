using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetAverageTotalFeeMonthlyQueryHandler : IRequestHandler<GetAverageTotalFeeMonthlyQuery, GetAverageTotalFeeMonthlyQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetAverageTotalFeeMonthlyQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }

    public Task<GetAverageTotalFeeMonthlyQueryResult> Handle(GetAverageTotalFeeMonthlyQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetAverageTotalFeeMonthly();
        return Task.FromResult(new GetAverageTotalFeeMonthlyQueryResult()
        {
            AverageMonthlyFee = value
        });
    }
}
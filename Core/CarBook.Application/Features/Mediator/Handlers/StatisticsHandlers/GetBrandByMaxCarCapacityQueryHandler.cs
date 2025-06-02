using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetBrandByMaxCarCapacityQueryHandler : IRequestHandler<GetBrandByMaxCarCapacityQuery, GetBrandByMaxCarCapacityQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetBrandByMaxCarCapacityQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }

    public Task<GetBrandByMaxCarCapacityQueryResult> Handle(GetBrandByMaxCarCapacityQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetBrandByMaxCarCapacity();
        return Task.FromResult(new GetBrandByMaxCarCapacityQueryResult()
        {
            BrandName = value
        });
    }
}
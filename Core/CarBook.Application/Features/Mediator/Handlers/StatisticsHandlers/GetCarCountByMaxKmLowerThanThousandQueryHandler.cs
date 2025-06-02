using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers;

public class GetCarCountByMaxKmLowerThanThousandQueryHandler : IRequestHandler<GetCarCountByMaxKmLowerThanThousandQuery,GetCarCountByMaxKmLowerThanThousandQueryResult>
{
    private readonly IStatisticsRepository _repository;

    public GetCarCountByMaxKmLowerThanThousandQueryHandler(IStatisticsRepository repository)
    {
        _repository = repository;
    }

    public Task<GetCarCountByMaxKmLowerThanThousandQueryResult> Handle(GetCarCountByMaxKmLowerThanThousandQuery request, CancellationToken cancellationToken)
    {
        var value = _repository.GetCarCountByMaxKmLowerThanThousand();
        return Task.FromResult(new GetCarCountByMaxKmLowerThanThousandQueryResult()
        {
            CarCountMaxKmLowerThan1000 = value
        });
    }
}
using CarBook.Application.Features.Mediator.Commands.CarPricingCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers;

public class RemoveCarPricingCommandHandler : IRequestHandler<RemoveCarPricingCommand>
{
    private readonly IRepository<CarPricing> _repository;

    public RemoveCarPricingCommandHandler(IRepository<CarPricing> repository)
    {
        _repository = repository;
    }

    public async Task Handle(RemoveCarPricingCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.RemoveAsync(value);
    }
}
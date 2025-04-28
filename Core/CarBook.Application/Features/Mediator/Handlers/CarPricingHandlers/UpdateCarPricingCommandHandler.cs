using CarBook.Application.Features.Mediator.Commands.CarPricingCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers;

public class UpdateCarPricingCommandHandler : IRequestHandler<UpdateCarPricingCommand>
{
    private readonly IRepository<CarPricing> _repository;

    public UpdateCarPricingCommandHandler(IRepository<CarPricing> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateCarPricingCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.CarPricingId);
        value.PricingId = request.PricingId;
        value.CarId = request.CarId;
        value.Amount = request.Amount;
        await _repository.UpdateAsync(value);
    }
}
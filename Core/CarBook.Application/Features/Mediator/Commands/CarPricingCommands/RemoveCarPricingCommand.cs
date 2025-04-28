using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.CarPricingCommands;

public class RemoveCarPricingCommand : IRequest
{
    public RemoveCarPricingCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
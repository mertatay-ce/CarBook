using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.SocialMediaCommands;

public class RemoveSocialMediaCommand : IRequest
{
    public int Id { get; set; }

    public RemoveSocialMediaCommand(int ıd)
    {
        Id = ıd;
    }
}
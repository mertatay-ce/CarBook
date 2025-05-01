using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.TagCloudCommands;

public class CreateTagCloudCommand : IRequest
{
  
    public string TagCloudName { get; set; }
    public int BlogId { get; set; }
}
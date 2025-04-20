using CarBook.Application.Features.CQRS.Commands.ContactCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers;

public class CreateContactCommandHandler
{
    private readonly IRepository<Contact> _repository;

    public CreateContactCommandHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateContactCommand command)
    {
        TimeZoneInfo gmtPlus3 = TimeZoneInfo.CreateCustomTimeZone(
            "GMT+3", TimeSpan.FromHours(3), "GMT+3", "GMT+3");

        // UTC (GMT) zamanı al
        DateTime gmtDateTime = DateTime.UtcNow;

        // GMT+3 zamanına dönüştür
        DateTime gmtPlus3DateTime = TimeZoneInfo.ConvertTimeFromUtc(gmtDateTime, gmtPlus3);
        await _repository.CreateAsync(new Contact()
        {
            Email = command.Email,
            Name = command.Name,
            SendDate = gmtPlus3DateTime,
            Subject = command.Subject,
            Message = command.Message
        });
    }
}
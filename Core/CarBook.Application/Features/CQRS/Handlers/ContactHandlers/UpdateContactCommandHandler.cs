using CarBook.Application.Features.CQRS.Commands.ContactCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers;

public class UpdateContactCommandHandler
{
    private readonly IRepository<Contact> _repository;

    public UpdateContactCommandHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateContactCommand command)
    {
        TimeZoneInfo gmtPlus3 = TimeZoneInfo.CreateCustomTimeZone(
            "GMT+3", TimeSpan.FromHours(3), "GMT+3", "GMT+3");

        // UTC (GMT) zamanı al
        DateTime gmtDateTime = DateTime.UtcNow;

        // GMT+3 zamanına dönüştür
        DateTime gmtPlus3DateTime = TimeZoneInfo.ConvertTimeFromUtc(gmtDateTime, gmtPlus3);
        var contact = await _repository.GetByIdAsync(command.ContactId);
        contact.Name = command.Name;
        contact.Email = command.Email;
        contact.Message = command.Message;
        contact.SendDate = gmtPlus3DateTime;
        contact.Subject = command.Subject;
        await _repository.UpdateAsync(contact);
    }
}
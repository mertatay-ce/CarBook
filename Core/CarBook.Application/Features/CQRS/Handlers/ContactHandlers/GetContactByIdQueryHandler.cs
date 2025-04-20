using CarBook.Application.Features.CQRS.Queries.ContactQueries;
using CarBook.Application.Features.CQRS.Results.ContactResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers;

public class GetContactByIdQueryHandler
{
    private readonly IRepository<Contact> _repository;

    public GetContactByIdQueryHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
    {
        var contact = await _repository.GetByIdAsync(query.Id);
        return new GetContactByIdQueryResult
        {
            ContactId = contact.ContactId,
            Email = contact.Email,
            Message = contact.Message,
            Name = contact.Name,
            SendDate = contact.SendDate,
            Subject = contact.Subject
        };
    }
}
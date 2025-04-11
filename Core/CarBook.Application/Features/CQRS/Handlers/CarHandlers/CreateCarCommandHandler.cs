using CarBook.Application.Features.CQRS.Commands.BrandCommands;
using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class CreateCarCommandHandler
{
    private readonly IRepository<Car> _repository;

    public CreateCarCommandHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateCarCommand command)
    {
        await _repository.CreateAsync(new Car()
        {
            BrandId = command.BrandId,
            Mileage = command.Mileage,
            Model = command.Model,
            Transmission = command.Transmission,
            Seats = command.Seats,
            Luggage = command.Luggage,
            CoverImageUrl = command.CoverImageUrl,
            ImageUrl = command.ImageUrl,
            Fuel = command.Fuel,
        });
    }
}
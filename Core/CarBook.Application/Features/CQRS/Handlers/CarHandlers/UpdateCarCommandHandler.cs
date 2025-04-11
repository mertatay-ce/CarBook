using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers;

public class UpdateCarCommandHandler
{
    private readonly IRepository<Car> _repository;

    public UpdateCarCommandHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateCarCommand command)
    {
        var value= await _repository.GetByIdAsync(command.CarId);
        value.Fuel = command.Fuel;
        value.BrandId = command.BrandId;
        value.Model = command.Model;
        value.Luggage = command.Luggage;
        value.Mileage = command.Mileage;
        value.Seats = command.Seats;
        value.Transmission = command.Transmission;
        value.ImageUrl = command.ImageUrl;
        value.CoverImageUrl = command.CoverImageUrl;
        
        await _repository.UpdateAsync(value);
    }
}
using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers;

public class UpdateBannerCommandHandler
{
    private readonly IRepository<Banner> _repository;

    public UpdateBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateBannerCommand command)
    {
        var banner = await _repository.GetByIdAsync(command.BannerId);
        banner.Description = command.Description;
        banner.Title = command.Title;
        banner.VideoDescription = command.VideoDescription;
        banner.VideoUrl = command.VideoUrl;
        await _repository.UpdateAsync(banner);
    }
}
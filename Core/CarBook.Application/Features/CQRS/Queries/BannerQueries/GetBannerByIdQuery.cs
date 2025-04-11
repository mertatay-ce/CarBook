namespace CarBook.Application.Features.CQRS.Queries.BannerQueries;

public class GetBannerByIdQuery
{
    public int Id { get; set; }

    public GetBannerByIdQuery(int ıd)
    {
        Id = ıd;
    }
}
namespace CarBook.Application.Features.CQRS.Queries.BrandQueries;

public class GetBrandByIdQuery
{
    public GetBrandByIdQuery(int ıd)
    {
        Id = ıd;
    }

    public int Id { get; set; }
}
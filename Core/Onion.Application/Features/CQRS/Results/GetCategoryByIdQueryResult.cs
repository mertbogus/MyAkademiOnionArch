namespace Onion.Application.Features.CQRS.Results
{
    public record GetCategoryByIdQueryResult
    {
        public Guid CategoryId { get; init; }
        public string CategoryName { get; init; }
    }
}

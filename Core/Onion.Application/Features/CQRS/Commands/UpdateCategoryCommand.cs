namespace Onion.Application.Features.CQRS.Commands
{
    public record UpdateCategoryCommand
    {
        public Guid CategoryId { get; init; }
        public string CategoryName { get; init; }
    }
}

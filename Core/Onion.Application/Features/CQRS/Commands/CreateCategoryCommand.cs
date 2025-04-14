namespace Onion.Application.Features.CQRS.Commands
{
    public record CreateCategoryCommand
    {
        public string CategoryName { get; init; }
    }
}

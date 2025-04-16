using MediatR;

namespace Onion.Application.Features.Mediator.Commands
{
    public record CreateProductCommand : IRequest<bool>
    {
        public string ProductName { get; init; }
        public decimal ProductPrice { get; init; }
        public int ProductStok { get; init; }

        public Guid CategoryId { get; init; }
    }
}

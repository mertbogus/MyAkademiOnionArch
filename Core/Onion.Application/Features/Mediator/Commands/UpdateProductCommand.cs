using MediatR;

namespace Onion.Application.Features.Mediator.Commands
{
    public record UpdateProductCommand : IRequest<bool>
    {
        public Guid ProductId { get; init; }
        public string ProductName { get; init; }
        public decimal ProductPrice { get; init; }
        public int ProductStok { get; init; }

        public Guid CategoryId { get; init; }
    }
}

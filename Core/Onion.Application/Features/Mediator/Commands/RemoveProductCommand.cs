using MediatR;

namespace Onion.Application.Features.Mediator.Commands
{
    public record RemoveProductCommand : IRequest<bool>
    {
        public Guid ProductId { get; init; }

        public RemoveProductCommand(Guid productId)
        {
            ProductId = productId;
        }
    }
}

using Onion.Application.Features.CQRS.Results;
using Onion.Domain.Entities;

namespace Onion.Application.Features.Mediator.Results
{
    public record GetProductQueryResult
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStok { get; set; }

        public Guid CategoryId { get; set; }
        public GetCategoryQueryResult Category { get; set; }
    }
}

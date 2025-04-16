namespace Onion.Application.Features.Mediator.Results
{
    public record GetProductByIdQueryResult
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStok { get; set; }

        public Guid CategoryId { get; set; }
    }
}

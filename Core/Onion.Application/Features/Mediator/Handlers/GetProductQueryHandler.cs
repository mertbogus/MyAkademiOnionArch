using AutoMapper;
using MediatR;
using Onion.Application.Features.Mediator.Queries;
using Onion.Application.Features.Mediator.Results;
using Onion.Application.Interfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Features.Mediator.Handlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var products = await _repository.GetAllAsync();
            return _mapper.Map<List<GetProductQueryResult>>(products);
        }
    }
}

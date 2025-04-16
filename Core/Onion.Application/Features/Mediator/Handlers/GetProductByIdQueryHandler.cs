using AutoMapper;
using MediatR;
using Onion.Application.Features.Mediator.Queries;
using Onion.Application.Features.Mediator.Results;
using Onion.Application.Interfaces;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.Mediator.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Product> _repository;

        public GetProductByIdQueryHandler(IMapper mapper, IRepository<Product> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.ProductId);
            return _mapper.Map<GetProductByIdQueryResult>(product);
        }
    }
}

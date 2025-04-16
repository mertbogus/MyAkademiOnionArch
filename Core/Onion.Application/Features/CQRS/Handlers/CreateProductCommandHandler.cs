using AutoMapper;
using MediatR;
using Onion.Application.Features.Mediator.Commands;
using Onion.Application.Interfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Features.CQRS.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductCommandHandler(IRepository<Product> repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request);
            await _repository.CreateAsync(product);
            return await _unitOfWork.SaveChangesAsync();

        }
    }
}

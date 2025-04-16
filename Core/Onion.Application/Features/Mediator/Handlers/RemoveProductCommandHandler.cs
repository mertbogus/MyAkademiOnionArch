using AutoMapper;
using MediatR;
using Onion.Application.Features.Mediator.Commands;
using Onion.Application.Interfaces;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.Mediator.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand, bool>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public RemoveProductCommandHandler(IRepository<Product> repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(request.ProductId);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
}
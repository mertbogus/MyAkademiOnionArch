using AutoMapper;
using Onion.Application.Features.CQRS.Commands;
using Onion.Application.Interfaces;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.CQRS.Handlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCategoryCommandHandler(IRepository<Category> repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(CreateCategoryCommand createCategoryCommand)
        {
            var category = _mapper.Map<Category>(createCategoryCommand);
            await _repository.CreateAsync(category);
            return await _unitOfWork.SaveChangesAsync();
        }
    }
}

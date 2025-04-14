using AutoMapper;
using Onion.Application.Features.CQRS.Commands;
using Onion.Application.Features.CQRS.Results;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Mappings
{
    public  class CategoryMappingProfile: Profile
    {
        public CategoryMappingProfile()
        {
               CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
               CreateMap<Category, GetCategoryByIdQueryResult>().ReverseMap();
               CreateMap<Category, CreateCategoryCommand>().ReverseMap();
        }
    }
}

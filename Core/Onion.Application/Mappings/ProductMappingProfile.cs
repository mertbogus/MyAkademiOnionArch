using AutoMapper;
using Onion.Application.Features.Mediator.Commands;
using Onion.Application.Features.Mediator.Results;
using Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Mappings
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
                CreateMap<Product, GetProductQueryResult>().ReverseMap();
                CreateMap<Product, CreateProductCommand>().ReverseMap();
                CreateMap<Product, GetProductByIdQueryResult>().ReverseMap();
                CreateMap<Product, UpdateProductCommand>().ReverseMap();
        }
    }
}

using MediatR;
using Onion.Application.Features.Mediator.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.Mediator.Queries
{
    public class GetProductQuery : IRequest<List<GetProductQueryResult>>
    {
    }
}

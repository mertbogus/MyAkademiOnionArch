using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.CQRS.Results
{
    public record GetCategoryQueryResult
    {          
        public Guid CategoryId { get; init; }
        public string CategoryName { get; init; }
    }
}

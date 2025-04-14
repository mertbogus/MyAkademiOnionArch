using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Features.CQRS.Commands
{
    public record RemoveCategoryCommand
    {
        public RemoveCategoryCommand(Guid categoryId)
        {
            CategoryId = categoryId;
        }

        public Guid CategoryId { get; init; }
    }
}

using MediatR;
using Microsoft.EntityFrameworkCore;
using SearchAPI.Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using SearchAPI.Domain.Entities;

namespace SearchAPI.Service.Features.CustomerFeatures.Queries
{
    public class GetAllDataQuery : IRequest<IEnumerable<Output>>
    {
        
        public class GetAllDataQueryHandler : IRequestHandler<GetAllDataQuery, IEnumerable<Output>>
        {
            private readonly IApplicationDbContext _context;
            public GetAllDataQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Output>> Handle(GetAllDataQuery request, CancellationToken cancellationToken)
            {
                var output = await _context.Output.ToListAsync();
                if (output == null) return null;
                return output.AsReadOnly().Take(50);
            }
        }
    }
}

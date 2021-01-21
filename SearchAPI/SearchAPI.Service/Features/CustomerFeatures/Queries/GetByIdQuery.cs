using MediatR;
using SearchAPI.Domain.Entities;
using SearchAPI.Persistence;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SearchAPI.Service.Features.CustomerFeatures.Queries
{
    public class GetDataByIdQuery : IRequest<Output>
    {
        public string Id { get; set; }
        public class GetDataByIdQueryHandler : IRequestHandler<GetDataByIdQuery, Output>
        {
            private readonly IApplicationDbContext _context;
            public GetDataByIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<Output> Handle(GetDataByIdQuery request, CancellationToken cancellationToken)
            {
                var output = _context.Output.Where(a => a.Column1 == request.Id).FirstOrDefault();
                if (output == null) return null;
                return output;
            }
        }
    }
}

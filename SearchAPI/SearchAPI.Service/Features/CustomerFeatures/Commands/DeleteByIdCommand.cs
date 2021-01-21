using MediatR;
using Microsoft.EntityFrameworkCore;
using SearchAPI.Persistence;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SearchAPI.Service.Features.CustomerFeatures.Commands
{
    public class DeleteByIdCommand : IRequest<string>
    {
        public string Id { get; set; }
        public class DeleteByIdCommandHandler : IRequestHandler<DeleteByIdCommand, string>
        {
            private readonly IApplicationDbContext _context;
            public DeleteByIdCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<string> Handle(DeleteByIdCommand request, CancellationToken cancellationToken)
            {
                var d = await _context.Output.Where(a => a.Column1 == request.Id).FirstOrDefaultAsync();
                if (d == null) return default;
                _context.Output.Remove(d);
                await _context.SaveChangesAsync();
                return d.Column1;
            }
        }
    }
}

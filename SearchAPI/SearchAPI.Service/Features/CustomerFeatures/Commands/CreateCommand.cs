using MediatR;
using SearchAPI.Domain.Entities;
using SearchAPI.Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace SearchAPI.Service.Features.CustomerFeatures.Commands
{
    public class CreateCommand : IRequest<string>
    {
        public string UserName { get; set; }
        public string Folder { get; set; }
        public string Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Cc { get; set; }
        public string MimeVersion { get; set; }
        public string ContentType { get; set; }
        public string ContentTransferEncoding { get; set; }
        public string Bcc { get; set; }
        public string Xfrom { get; set; }
        public string Xto { get; set; }
        public string Xcc { get; set; }
        public string Xbcc { get; set; }
        public string Xfolder { get; set; }
        public string Xorigin { get; set; }
        public string XfileName { get; set; }
        public string Body { get; set; }
        public class CreateCommandHandler : IRequestHandler<CreateCommand, string>
        {
            private readonly IApplicationDbContext _context;
            public CreateCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<string> Handle(CreateCommand request, CancellationToken cancellationToken)
            {
                var d = new Output();
                d.Body = request.Body;
                d.UserName = request.UserName;

                _context.Output.Add(d);
                await _context.SaveChangesAsync();
                return d.Column1;
            }
        }
    }
}

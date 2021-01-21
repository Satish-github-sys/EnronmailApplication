using MediatR;
using SearchAPI.Persistence;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SearchAPI.Service.Features.CustomerFeatures.Commands
{
    public class UpdateCommand : IRequest<string>
    {
        public string Column1 { get; set; }
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
        public class UpdateCommandHandler : IRequestHandler<UpdateCommand, string>
        {
            private readonly IApplicationDbContext _context;
            public UpdateCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<string> Handle(UpdateCommand request, CancellationToken cancellationToken)
            {
                var c = _context.Output.Where(a => a.Column1 == request.Column1).FirstOrDefault();

                if (c == null)
                {
                    return default;
                }
                else
                {
                    c.UserName = request.UserName;
                    c.Subject = request.Subject;
                    _context.Output.Update(c);
                    await _context.SaveChangesAsync();
                    return c.Column1;
                }
            }
        }
    }
}

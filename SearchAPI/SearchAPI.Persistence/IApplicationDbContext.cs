using Microsoft.EntityFrameworkCore;
using SearchAPI.Domain.Entities;
using System.Threading.Tasks;

namespace SearchAPI.Persistence
{
    public interface IApplicationDbContext
    {
       
        DbSet<Output> Output { get; set; }

        Task<int> SaveChangesAsync();
    }
}

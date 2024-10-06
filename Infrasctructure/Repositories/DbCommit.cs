using Trinode.Domain.Interfaces;
using Trinode.Infrastructure.Data;

namespace Trinode.Infrastructure.Repositories
{
    public class DbCommit : IDbCommit
    {
        private readonly TrinodeDbContext _context;

        public DbCommit(TrinodeDbContext context)
        {
            _context = context;
        }

        public async Task Commit(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}


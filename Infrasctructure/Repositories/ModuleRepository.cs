using Microsoft.EntityFrameworkCore;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;
using Trinode.Infrastructure.Data;

namespace Trinode.Infrastructure.Repositories
{
    public class ModuleRepository : BaseRepository<Module>, IModuleRepository
    {
        public ModuleRepository(TrinodeDbContext context) : base(context) {}

        public async Task<List<Module>> GetByCourse(Guid courseId, CancellationToken cancellationToken)
        {
            return await _context.Modules.Where(x => x.Course.Id.Equals(courseId)).ToListAsync(cancellationToken);
        }
    }
}


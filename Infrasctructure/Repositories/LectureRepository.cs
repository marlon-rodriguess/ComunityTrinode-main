using Microsoft.EntityFrameworkCore;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;
using Trinode.Infrastructure.Data;

namespace Trinode.Infrastructure.Repositories
{
    public class LectureRepository : BaseRepository<Lecture>, ILectureRepository
    {
        public LectureRepository(TrinodeDbContext context) : base(context){}

        public async Task<List<Lecture>> GetByModule(Guid moduleguid, CancellationToken cancellationToken)
        {
            return await _context.Lectures.Where(x => x.ModuleGuid.Equals(moduleguid)).ToListAsync(cancellationToken);
        }
    }
}


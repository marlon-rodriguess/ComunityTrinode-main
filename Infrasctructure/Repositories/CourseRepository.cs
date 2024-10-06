using Microsoft.EntityFrameworkCore;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;
using Trinode.Infrastructure.Data;

namespace Trinode.Infrastructure.Repositories
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(TrinodeDbContext context) : base(context){}

        public async Task<List<Course>> GetByCategory(Guid categoryId, CancellationToken cancellationToken)
        {
            return await _context.Courses.Where(x => x.Category.Id.Equals(categoryId)).ToListAsync(cancellationToken);
        }
    }
}
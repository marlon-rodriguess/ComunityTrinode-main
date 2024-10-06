using Trinode.Domain.Entities;

namespace Trinode.Domain.Interfaces
{
    public interface ICourseRepository : IBaseRepository<Course>
    {
        public Task<List<Course>> GetByCategory(Guid categoryId, CancellationToken cancellationToken);
    }
}


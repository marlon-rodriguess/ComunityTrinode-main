using Trinode.Domain.Entities;

namespace Trinode.Domain.Interfaces
{
    public interface ITeacherRepository : IBaseRepository<Teacher>
    {
        public Task<List<Teacher>> GetByCourse(Guid courseId, CancellationToken cancellationToken);
        public Task<List<Teacher>> GetByCategory(Guid categoryId, CancellationToken cancellationToken);
    }
}

using Trinode.Domain.Entities;

namespace Trinode.Domain.Interfaces
{
    public interface IModuleRepository : IBaseRepository<Module>
    {
        Task<List<Module>> GetByCourse(Guid courseId, CancellationToken cancellationToken);
    }
}


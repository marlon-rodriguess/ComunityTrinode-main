using Trinode.Domain.Entities;

namespace Trinode.Domain.Interfaces
{
    public interface ILectureRepository : IBaseRepository<Lecture>
    {
        Task<List<Lecture>> GetByModule(Guid moduleId, CancellationToken cancellationToken);
    }
}


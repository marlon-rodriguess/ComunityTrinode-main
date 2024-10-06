using Trinode.Domain.Entities;

namespace Trinode.Domain.Interfaces
{
    public interface IBaseRepository <T> where T : BaseEntity
    {
        public void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
        Task<T> GetById(Guid id, CancellationToken cancellationToken);
    }
}


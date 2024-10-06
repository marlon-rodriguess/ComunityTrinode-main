using Trinode.Domain.Interfaces;
using Trinode.Domain.Entities;
using Trinode.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Trinode.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly TrinodeDbContext _context;
        public BaseRepository(TrinodeDbContext context)
        {
            _context = context;
        }

        //Create the entity
        public virtual void Create(T entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            _context.Add(entity);   
        }

        //Update the entity
        public virtual void Update(T entity)
        {
            entity.UpdatedDate = DateTime.UtcNow;
            _context.Update(entity);
        }

        //Soft delete
        public virtual void Delete(T entity)
        {
            entity.DeletedDate = DateTime.UtcNow;
            _context.Remove(entity);
        }

        //Return a list of entities
        public virtual async Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return await _context.Set<T>().ToListAsync(cancellationToken)??
            throw new Exception("No entities found");
        }

        //Return an entity by id
        public virtual async Task<T> GetById(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id.Equals(id), cancellationToken);
        }
    }
}


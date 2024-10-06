using Trinode.Domain.Entities;
using Trinode.Infrastructure.Data;

namespace Trinode.Infrastructure.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(TrinodeDbContext context) : base(context){}
    }
}
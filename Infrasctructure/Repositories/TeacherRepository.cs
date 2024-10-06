using Microsoft.EntityFrameworkCore;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;
using Trinode.Infrastructure.Data;

namespace Trinode.Infrastructure.Repositories
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(TrinodeDbContext context) : base(context) { }

        public async Task<List<Teacher>> GetByCourse(Guid courseId, CancellationToken cancellationToken)
        {
            return await _context.Teachers.Where(x => x.Courses.Equals(courseId)).ToListAsync(cancellationToken);
            //IMPLEMENTAR QUERY MANUAL OU DAPPER PARA TRAZER DA TABELA DE RELACIONAMENTO
        }

        public async Task<List<Teacher>> GetByCategory(Guid categoryId, CancellationToken cancellationToken)
        {
            return await _context.Teachers.Where(x => x.Courses).ToListAsync(cancellationToken);
            //IMPLEMENTAR QUERY MANUAL OU DAPPER PARA TRAZER DA TABELA DE RELACIONAMENTO
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Trinode.Domain.Entities;
using Trinode.Domain.Interfaces;
using Trinode.Infrastructure.Data;
using Trinode.Infrastructure.Utilities;

namespace Trinode.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(TrinodeDbContext context) : base(context){}

        public async Task<User> GetByemail(string email, CancellationToken cancellationToken)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email.Equals(email), cancellationToken);
        }

        public override void Create(User entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            entity.Salt = Hasher<User>.GenerateSalt();
            entity.Password = Hasher<User>.HashPassword(entity.Password, entity.Salt);
            _context.Add(entity);
        }

        public async Task<bool> ValidateHash(BaseEntity entity, string password, CancellationToken cancellationToken)
        {
            try
            {
                var storedUser = _context.Users.AsNoTracking().FirstOrDefault(x => x.Id == entity.Id);
                if (storedUser == null)
                    return false; //Login Incorreto, pois não existe no banco

                var newPassword = Hasher<BaseEntity>.HashPassword(password, storedUser.Salt);
                if(storedUser.Password.Equals(newPassword))
                    return true; //Login bem sucedido
                else
                    return false; //Senha Incorreta
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao realizar o login: " + ex.Message);
                return false;
            }
        }
    }
}


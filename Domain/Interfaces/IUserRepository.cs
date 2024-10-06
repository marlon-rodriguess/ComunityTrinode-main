using Trinode.Domain.Entities;

namespace Trinode.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByemail(string email, CancellationToken cancellationToken);
        Task<bool> ValidateHash(BaseEntity user , string password, CancellationToken cancellationToken);
    }
}


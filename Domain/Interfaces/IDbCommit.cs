namespace Trinode.Domain.Interfaces
{
    public interface IDbCommit
    {
        Task Commit(CancellationToken cancellationToken);
    }
}


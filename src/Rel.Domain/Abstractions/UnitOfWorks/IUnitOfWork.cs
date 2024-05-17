namespace Rel.Domain.Abstractions.UnitOfWorks;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    Task<IDbContextTransaction> BeginTransactionAsync();
    Task CommitTransactionAsync(IDbContextTransaction transaction);
    Task<int> SaveChangesAsync();
    Task DisposeAsync();
}


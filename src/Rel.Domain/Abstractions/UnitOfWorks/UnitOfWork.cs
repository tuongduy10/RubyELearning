namespace Rel.Domain.Abstractions;

public class UnitOfWork : IUnitOfWork
{
    private readonly RelDbContext _dbContext;
    public UnitOfWork(RelDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IDbContextTransaction> BeginTransactionAsync()
    {
        return await _dbContext.Database.BeginTransactionAsync();
    }
    public async Task CommitTransactionAsync(IDbContextTransaction transaction)
    {
        await transaction.CommitAsync();
    }
    public async Task<int> SaveChangesAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }
    public void Dispose()
    {
        _dbContext.Dispose();
    }
    public async Task DisposeAsync()
    {
        await _dbContext.DisposeAsync();
    }
    public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
    {
        return new GenericRepository<TEntity>(_dbContext);
    }
}

using Microsoft.EntityFrameworkCore;
using Rel.Domain.Abstractions.UnitOfWorks;
using Rel.Infrastructure.Contexts;

namespace Rel.Application.Behaviors;

public class TransactionPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IUnitOfWork _uow;
    private readonly RelDbContext _dbContext;
    public TransactionPipelineBehavior(IUnitOfWork uow, RelDbContext dbContext)
    {
        _uow = uow;
        _dbContext = dbContext;
    }
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (!IsCommand())
            return await next(); 
        var strategy = _dbContext.Database.CreateExecutionStrategy();

        return await strategy.ExecuteAsync(async () =>
        {
            // Start the transaction
            await using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);

            try
            {
                // Proceed to the next handler
                var response = await next();
                // Save changes 
                await _dbContext.SaveChangesAsync();
                // Commit the transaction
                await transaction.CommitAsync(cancellationToken);

                return response;
            }
            catch
            {
                // Rollback the transaction
                await transaction.RollbackAsync(cancellationToken);
                throw;
            }
        });
    }

    private bool IsCommand() => typeof(TRequest).Name.EndsWith("Command");
}

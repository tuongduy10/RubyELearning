﻿using System.Linq.Expressions;

namespace Rel.Domain.Abstractions.Repositories;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(object id);
    Task AddAsync(TEntity entity);
    Task AddAsync(IEnumerable<TEntity> entities);
    void Update(TEntity entity);
    void Update(IEnumerable<TEntity> entities);
    void Delete(TEntity entity);
    void Delete(IEnumerable<TEntity> entities);
    Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter);
    Task<TEntity> FindLastAsync();
    Task<TEntity> FindByAsync(
        Expression<Func<TEntity, bool>> filter = null,
        string includeProperties = "");
    Task<IEnumerable<TEntity>> GetByAsync(
        Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "");
    IQueryable<TEntity> QueryableAsync(
        Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "");

    #region Paging
    //Task<PagedResult<TEntity>> GetPagedResultByAsync(
    //    int pageIndex,
    //    int pageSize,
    //    Expression<Func<TEntity, bool>> filter = null,
    //    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
    //    string includeProperties = "");
    //Task<PagedResult<TResult>> GetPagedMappingByAsync<TResult>(
    //    int pageIndex,
    //    int pageSize,
    //    Expression<Func<TEntity, bool>> filter = null,
    //    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
    //    string includeProperties = "");
    #endregion
}

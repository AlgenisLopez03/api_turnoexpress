﻿using System.Linq.Expressions;

namespace GestorDeTurnos.Application.Interfaces.Repositories
{
    public interface IAsyncRepository<TEntity>
    {
        Task CreateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);

        Task<List<TDestination>> GetAllProjectedAsync<TDestination>();

        Task<List<TDestination>> GetAllProjectedAsync<TDestination>(ISpecification<TEntity> spec);

        Task<TEntity?> GetByIdAsync(int id);

        Task<TDestination?> GetByIdProjectedAsync<TDestination>(int id);

        Task<int> GetTotalCountAsync(Expression<Func<TEntity, bool>> predicate);

        Task UpdateAsync(TEntity entity);

        Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
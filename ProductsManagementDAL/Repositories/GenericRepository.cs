﻿using Microsoft.EntityFrameworkCore;
using ProductsManagementDAL.Repositories.IRepositories;
using System.Linq.Expressions;

namespace ProductsManagementDAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        private readonly DataContext _dbContext;

        public GenericRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> Delete(TEntity entity)
        {
            var deleteIndex = _dbContext.Remove(entity);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            return await _dbContext.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                return await _dbContext.Set<TEntity>().ToListAsync();
            }
            return await _dbContext.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            var updateIndex = _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}

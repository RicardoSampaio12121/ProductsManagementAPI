using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementDAL.Repositories.IRepositories
{
    public interface IGenericRepository<T> where T : class, new()
    {
        /// <summary>
        /// Get a single entity/row
        /// </summary>
        /// <param name="filter"></param>
        Task<T> Get(Expression<Func<T, bool>> filter = null);
        /// <summary>
        /// Get multiple entities/rows
        /// </summary>
        /// <param name="filter"></param>
        Task<List<T>> GetList(Expression<Func<T, bool>> filter = null);
        /// <summary>
        /// Inserts a single entity/row in the database
        /// </summary>
        /// <param name="entity"></param>
        Task<T> Add(T entity);
        /// <summary>
        /// Updates an entity/row in the database
        /// </summary>
        /// <param name="entity"></param>
        Task<T> Update(T entity);
        /// <summary>
        /// Deletes an entity/row from the database
        /// </summary>
        /// <param name="entity"></param>
        Task<int> Delete(T entity);
    }
}

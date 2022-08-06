using ProductsManagementDAL.Repositories.IRepositories;
using ProductsManagementDTOs;
using ProductsManagementEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementDAL.Repositories
{
    public class ProductsRepository : GenericRepository<Products>, IProductsRepository
    {
        private readonly DataContext _dbContext;

        public ProductsRepository(DataContext dataContext) : base(dataContext)
        {
            _dbContext = dataContext;
        }
    }
}

using ProductsManagementDAL.Repositories.IRepositories;
using ProductsManagementDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementDAL.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        public Task AddNewProduct(AddProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}

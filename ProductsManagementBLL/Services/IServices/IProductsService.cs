using ProductsManagementDTOs;
using ProductsManagementEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementBLL.Services.IServices
{
    public interface IProductsService
    {
        Task<Products> AddNewProduct(AddProductDto product);
        Task<Products> GetProduct(int productId);
        Task UpdateStock(UpdateStockDto dto);
        Task DeleteProduct(int productId);
        Task<List<Products>> GetAllProducts();
    }
}

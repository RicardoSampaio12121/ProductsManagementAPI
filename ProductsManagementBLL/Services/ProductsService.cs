using ProductsManagementBLL.Services.IServices;
using ProductsManagementBLL.Utils;
using ProductsManagementDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementBLL.Services
{
    public class ProductsService : IProductsService
    {
        public async Task AddNewProduct(AddProductDto product)
        {
            // Verificar parametros
            Validators.ValidadeAddProductDto(product);

            // Verificar se não existe um produto igual


            // Adicionar produto
        }
    }
}

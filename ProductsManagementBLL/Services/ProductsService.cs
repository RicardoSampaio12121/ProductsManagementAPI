using ProductsManagementBLL.Services.IServices;
using ProductsManagementBLL.Utils;
using ProductsManagementDAL.Repositories.IRepositories;
using ProductsManagementDTOs;
using ProductsManagementEntities;

namespace ProductsManagementBLL.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _productsRepo;

        public ProductsService(IProductsRepository productsRepo)
        {
            _productsRepo = productsRepo;
        }

        public async Task<Products> GetProduct(int productId)
        {
            // Buscar produto
            var product = await _productsRepo.Get(query => query.Id == productId);

            // Verificar se existe
            if(product == null) throw new Exception("There is no product assigned with that Id");

            // Retornar
            return product;
        }

        public async Task<Products> AddNewProduct(AddProductDto product)
        {
            // Verificar parametros
            Validators.ValidadeAddProductDto(product);

            // Verificar se não existe um produto igual
            var checker = await _productsRepo.Get(query => query.Category == product.category && 
                                                  query.SubCategory == product.subCategory && 
                                                  query.Brand == product.brand && 
                                                  query.Model == product.model);

            if(checker != null) throw new Exception("Product already exists in the database!");

            // Adicionar produto e retornar resultado
            return await _productsRepo.Add(product.AsProducts());
        }

        public async Task UpdateStock(UpdateStockDto dto)
        {
            // Verificar se o produto existe
            var product = await _productsRepo.Get(query => query.Id == dto.productId);

            if (product == null) throw new Exception("There is no product assigned with that id");

            // Verificar se o stock não fica abaixo de 0
            if (product.Quantity + dto.amount < 0) throw new Exception("There are not enough products in stock");

            // Dar update ao stock
            product.Quantity = (uint)(product.Quantity + dto.amount);
            await _productsRepo.Update(product);
        }

        public async Task DeleteProduct(int productId)
        {
            // Verificar se o produto existe
            var product = await _productsRepo.Get(query => query.Id == productId);
            if (product == null) throw new Exception("There is no product assigned with that id");

            // Eliminar produto
            await _productsRepo.Delete(product);
        }

        public async Task<List<Products>> GetAllProducts()
        {
            // Buscar produtos
            var products = await _productsRepo.GetList();

            //Retornar lista de produtos
            return products;
        }
    }
}

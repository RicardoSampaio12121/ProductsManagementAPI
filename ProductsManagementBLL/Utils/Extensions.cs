using ProductsManagementDTOs;
using ProductsManagementEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementBLL.Utils
{
    public static class Extensions
    {
        public static Products AsProducts(this AddProductDto dto)
        {
            return new Products
            {
                Category = dto.category,
                SubCategory = dto.subCategory,
                Brand = dto.brand,
                Model = dto.model,
                Date = DateTime.Now,
                Quantity = dto.quantity
            };
        }
    }
}

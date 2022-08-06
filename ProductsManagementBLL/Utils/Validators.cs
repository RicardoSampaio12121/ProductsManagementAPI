using ProductsManagementDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementBLL.Utils
{
    public static class Validators
    {
        public static void ValidadeAddProductDto(AddProductDto dto)
        {
            if (dto.category == string.Empty)    throw new Exception("Category field is empty!");
            if (dto.subCategory == string.Empty) throw new Exception("SubCategory field is empty!");
            if (dto.brand == string.Empty)       throw new Exception("Brand field is empty!");
            if (dto.model == string.Empty)       throw new Exception("Model field is empty!");
        }
    }
}

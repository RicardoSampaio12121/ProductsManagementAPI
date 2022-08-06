using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementDTOs
{
    public record AddProductDto(string category, string subCategory, string brand, string model, uint quantity);
}

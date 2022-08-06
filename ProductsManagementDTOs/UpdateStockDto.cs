using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementDTOs
{
    public record UpdateStockDto(int productId, int amount);
}

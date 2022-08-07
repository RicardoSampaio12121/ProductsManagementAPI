using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementDTOs.UsersDtos
{
    public record LoginDto(int uid, string password);
}

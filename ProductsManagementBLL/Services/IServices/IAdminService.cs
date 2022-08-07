using ProductsManagementDTOs.UsersDtos;
using ProductsManagementEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementBLL.Services.IServices
{
    public interface IAdminService
    {
        Task<Users> CreateNewUser(NewUserDto dto);
        Task<Users> GetUser(int uid);
    }
}

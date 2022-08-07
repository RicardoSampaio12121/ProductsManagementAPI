using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementDTOs.UsersDtos
{
    public record NewUserDto(string name, string surname, DateTime birthDate, string role, string password);
}

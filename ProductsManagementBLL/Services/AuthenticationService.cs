using ProductsManagementBLL.Services.IServices;
using ProductsManagementBLL.Utils;
using ProductsManagementDAL.Repositories.IRepositories;
using ProductsManagementDTOs.AuthenticationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementBLL.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationRepository _authRepo;

        public AuthenticationService(IAuthenticationRepository authRepo)
        {
            _authRepo = authRepo;
        }

        public async Task<ReturnLoginInfoDto> Login(LoginDto dto)
        {
            // Buscar utilizador
            var user = await _authRepo.Get(query => query.Id == dto.uid);
            
            // Verificar se utilizador existe
            if (user == null) throw new Exception("There is no user assigned with that id!");

            //TODO: Comparar passwords encriptadas

            //TODO: Eliminar esta parte que compara passwords por encriptar
            if (user.Password != dto.password) throw new Exception("Wrong id or password!");

            // Criar jwt
            var jwt = OAuth.CreateToken(dto.uid, user.Role);

            return new ReturnLoginInfoDto(jwt);
        
        }
    }
}

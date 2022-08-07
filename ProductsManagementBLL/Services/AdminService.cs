using ProductsManagementBLL.Services.IServices;
using ProductsManagementBLL.Utils;
using ProductsManagementDAL.Repositories.IRepositories;
using ProductsManagementDTOs.UsersDtos;
using ProductsManagementEntities;

namespace ProductsManagementBLL.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUsersRepository _usersRepo;

        public AdminService(IUsersRepository usersRepo)
        {
            _usersRepo = usersRepo;
        }

        public async Task<Users> CreateNewUser(NewUserDto dto)
        {
            // Encriptar password
            var encriptedPassword = PasswordUtils.Encrypt(dto.password);

            var user = new Users()
            {
                Name = dto.name,
                Surname = dto.surname,
                BirthDate = dto.birthDate,
                Role = dto.role,
                Password = encriptedPassword
            };

            var createdUser = await _usersRepo.Add(user);

            return createdUser;
        }

        public async Task<Users> GetUser(int uid)
        {
            // Verificar se utilizador existe
            var user = await _usersRepo.Get(query => query.Id == uid);

            if (user == null) throw new Exception("There is no user assigned with that id!");

            return user;
        }
    }
}

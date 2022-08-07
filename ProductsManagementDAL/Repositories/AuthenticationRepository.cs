using ProductsManagementDAL.Repositories.IRepositories;
using ProductsManagementEntities;

namespace ProductsManagementDAL.Repositories
{
    public class AuthenticationRepository : GenericRepository<Users>, IAuthenticationRepository
    {
        private readonly DataContext _dataContext;

        public AuthenticationRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}

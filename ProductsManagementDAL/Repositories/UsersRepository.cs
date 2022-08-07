using ProductsManagementDAL.Repositories.IRepositories;
using ProductsManagementEntities;

namespace ProductsManagementDAL.Repositories
{
    public class UsersRepository : GenericRepository<Users>, IUsersRepository
    {
        private readonly DataContext _dataContext;

        public UsersRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}

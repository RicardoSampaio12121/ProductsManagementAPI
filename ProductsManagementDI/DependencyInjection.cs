using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductsManagementBLL.Services;
using ProductsManagementBLL.Services.IServices;
using ProductsManagementDAL;
using ProductsManagementDAL.Repositories;
using ProductsManagementDAL.Repositories.IRepositories;

namespace ProductsManagementDI
{
    public class DependencyInjection
    {
        private readonly IConfiguration Configuration;
        public DependencyInjection(IConfiguration config)
        {
            Configuration = config;
        }

        public void InjectDependencies(IServiceCollection services)
        {

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer("Server = localhost; Database = BikeSocialDB; Trusted_Connection = True;");
            });

            services.AddScoped<IProductsService, ProductsService>();
            services.AddScoped<IProductsRepository, ProductsRepository>();

            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUsersRepository, UsersRepository>();

            services.AddScoped<IAdminService, AdminService>();
        }
    }
}

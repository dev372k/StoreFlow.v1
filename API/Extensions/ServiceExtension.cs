using DAL.Repositories.Implementations;
using DAL.Repositories.Interfaces;

namespace API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ServicesRegistry(this IServiceCollection services, IConfiguration configuration)
        {
            services.Misc();
        }

        public static void Misc(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}

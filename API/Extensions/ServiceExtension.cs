using Persistence.Repositories.Implementations;
using Persistence.Repositories.Interfaces;

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
            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IRepository, Repository>();
            services.AddHttpContextAccessor();
            //services.AddSingleton<IStateHelper, StateHelper>();
        }
    }
}

using IocWithInjectionDependency.Application;
using IocWithInjectionDependency.Infrastructure;
using IocWithInjectionDependency.Infrastructure.Contexts;

namespace IocWithInjectionDependency.Core
{
    public static class IocTool
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            services.AddDbContext<EmployeeContext>();
            services.AddScoped<EmployeeDal>();
            services.AddScoped<EmployeeManager>();
        }

    }
}

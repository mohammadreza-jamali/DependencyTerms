using DiWithIocAndInjectionDependency.Application;
using DiWithIocAndInjectionDependency.Application.Abstract;
using DiWithIocAndInjectionDependency.Infrastructure.Abstract;
using DiWithIocAndInjectionDependency.Infrastructure.Concrete.EntityFramework;
using DiWithIocAndInjectionDependency.Infrastructure.Concrete.EntityFramework.Contexts;

namespace DiWithIocAndInjectionDependency.Core
{
    public static class IocTool
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            services.AddDbContext<EmployeeContext>();
            services.AddScoped<IEmployeeDal, EfEmployeeDal>();
            services.AddScoped<IEmployeeService, EmployeeManager>();
        }

    }
}

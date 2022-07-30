using DiWithIocAndInjectionDependency.Entity;
using System.Linq.Expressions;

namespace DiWithIocAndInjectionDependency.Infrastructure.Abstract
{
    public interface IEmployeeDal
    {
        Task Add(Employee employee);
        Task<List<Employee>> GetList(Expression<Func<Employee, bool>> filter = null);
    }
}

using DiWithIocAndInjectionDependency.Entity;
using DiWithIocAndInjectionDependency.Entity.Dtos;

namespace DiWithIocAndInjectionDependency.Application.Abstract
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
        Task AddEmployee(AddEmployeeDto dto);
    }
}

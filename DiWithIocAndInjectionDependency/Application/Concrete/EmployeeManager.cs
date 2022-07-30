using DiWithIocAndInjectionDependency.Application.Abstract;
using DiWithIocAndInjectionDependency.Entity;
using DiWithIocAndInjectionDependency.Entity.Dtos;
using DiWithIocAndInjectionDependency.Infrastructure.Abstract;

namespace DiWithIocAndInjectionDependency.Application
{
    public class EmployeeManager:IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _employeeDal.GetList();
        }
        public async Task AddEmployee(AddEmployeeDto dto)
        {
            await _employeeDal.Add(new Employee
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                InsertedDateTime = DateTime.UtcNow
            });
        }

    }
}

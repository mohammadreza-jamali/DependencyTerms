using IocWithInjectionDependency.Entity;
using IocWithInjectionDependency.Entity.Dtos;
using IocWithInjectionDependency.Infrastructure;

namespace IocWithInjectionDependency.Application
{
    public class EmployeeManager
    {
        private readonly EmployeeDal _employeeDal;

        public EmployeeManager(EmployeeDal employeeDal)
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

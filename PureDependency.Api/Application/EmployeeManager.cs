using PureDependency.Api.Entity;
using PureDependency.Api.Entity.Dtos;
using PureDependency.Api.Infrastructure;

namespace PureDependency.Api.Application
{
    public class EmployeeManager
    {
        private readonly EmployeeDal _employeeDal;
        public EmployeeManager()
        {
            _employeeDal = new EmployeeDal();
        }
        public async Task<List<Employee>> GetEmployees()
        {
            return await _employeeDal.GetList();
        }
        public async Task AddEmployee(AddEmployeeDto dto)
        {
            await _employeeDal.Add(new Employee {
                FirstName=dto.FirstName,
                LastName=dto.LastName,
                InsertedDateTime=DateTime.UtcNow
            });
        }

    }
}

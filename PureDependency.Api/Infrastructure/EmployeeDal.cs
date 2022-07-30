using Microsoft.EntityFrameworkCore;
using PureDependency.Api.Entity;
using PureDependency.Api.Infrastructure.Contexts;
using System.Linq.Expressions;

namespace PureDependency.Api.Infrastructure
{
    public class EmployeeDal
    {
        private readonly EmployeeContext _context;
        public EmployeeDal()
        {
            _context=new EmployeeContext();
        }
        public async Task Add(Employee employee)
        {
           await _context.Employees.AddAsync(employee);
           await _context.SaveChangesAsync();
        }
        public async Task<List<Employee>> GetList(Expression<Func<Employee, bool>> filter=null)
        {
            return filter == null
                ? await _context.Set<Employee>().ToListAsync()
                : await _context.Set<Employee>().Where(filter).ToListAsync();
        }
    }
}

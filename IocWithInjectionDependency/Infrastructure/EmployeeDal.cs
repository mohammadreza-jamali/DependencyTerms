using IocWithInjectionDependency.Core;
using IocWithInjectionDependency.Entity;
using IocWithInjectionDependency.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IocWithInjectionDependency.Infrastructure
{
    public class EmployeeDal
    {
        private readonly EmployeeContext _context;

        public EmployeeDal(EmployeeContext context)
        {
            _context = context;
        }

        public async Task Add(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Employee>> GetList(Expression<Func<Employee, bool>> filter = null)
        {
            return filter == null
                ? await _context.Set<Employee>().ToListAsync()
                : await _context.Set<Employee>().Where(filter).ToListAsync();
        }
    }
}

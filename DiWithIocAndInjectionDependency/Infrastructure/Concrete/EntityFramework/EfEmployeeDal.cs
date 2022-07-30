using DiWithIocAndInjectionDependency.Entity;
using DiWithIocAndInjectionDependency.Infrastructure.Abstract;
using DiWithIocAndInjectionDependency.Infrastructure.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DiWithIocAndInjectionDependency.Infrastructure.Concrete.EntityFramework
{
    public class EfEmployeeDal:IEmployeeDal
    {
        private readonly EmployeeContext _context;

        public EfEmployeeDal(EmployeeContext context)
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

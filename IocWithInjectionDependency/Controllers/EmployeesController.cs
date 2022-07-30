using IocWithInjectionDependency.Application;
using IocWithInjectionDependency.Entity.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace IocWithInjectionDependency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeManager _employeeManager;

        public EmployeesController(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        [HttpGet(template: "getlist")]
        public async Task<IActionResult> GetList()
        {
            return Ok(await _employeeManager.GetEmployees());
        }

        [HttpPost(template: "addemployee")]
        public async Task<IActionResult> AddEmployee(AddEmployeeDto dto)
        {
            await _employeeManager.AddEmployee(dto);
            return Ok();
        }
    }
}

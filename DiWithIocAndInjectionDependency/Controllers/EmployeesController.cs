using DiWithIocAndInjectionDependency.Application.Abstract;
using DiWithIocAndInjectionDependency.Entity.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DiWithIocAndInjectionDependency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet(template: "getlist")]
        public async Task<IActionResult> GetList()
        {
            return Ok(await _employeeService.GetEmployees());
        }

        [HttpPost(template: "addemployee")]
        public async Task<IActionResult> AddEmployee(AddEmployeeDto dto)
        {
            await _employeeService.AddEmployee(dto);
            return Ok();
        }
    }
}

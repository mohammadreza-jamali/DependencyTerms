using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PureDependency.Api.Application;
using PureDependency.Api.Entity.Dtos;

namespace PureDependency.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeManager _employeeManager;
        public EmployeesController()
        {
            _employeeManager = new EmployeeManager();
        }

        [HttpGet(template:"getlist")]
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

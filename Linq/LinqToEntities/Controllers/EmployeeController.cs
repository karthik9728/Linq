using LinqToEntities.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LinqToEntities.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _employeeService.Get();

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpGet("Projection")]
        public async Task<IActionResult> GetProjection()
        {
            var result = await _employeeService.GetProjection();

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _employeeService.GetById(id);

            if (result == null) return NotFound();

            return Ok(result);
        }
    }
}

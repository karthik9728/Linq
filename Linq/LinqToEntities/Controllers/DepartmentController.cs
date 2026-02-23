using LinqToEntities.Services;
using Microsoft.AspNetCore.Mvc;

namespace LinqToEntities.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _departmentService.Get();

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpGet("Projection")]
        public async Task<IActionResult> GetProjection()
        {
            var result = await _departmentService.GetProjection();

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpGet("Projection/Query")]
        public async Task<IActionResult> GetProjectionQueryable()
        {
            var result = await _departmentService.GetProjectionWithQueryable();

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpGet("Projection/{name}")]
        public async Task<IActionResult> GetProjection(string name)
        {
            var result = await _departmentService.GetProjection(name);

            if (result == null) return NotFound();

            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _departmentService.GetById(id);

            if (result == null) return NotFound();

            return Ok(result);
        }
    }
}

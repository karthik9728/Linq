using LinqToEntities.DTO;
using LinqToEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace LinqToEntities.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmpManagementContext _dbContext;

        public EmployeeService(EmpManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Employee>> Get()
        {
            return await _dbContext.Employees.ToListAsync();
        }

        public async Task<List<EmployeeDto>> GetProjection()
        {
            return await _dbContext.Employees.Select(x=> new EmployeeDto
            {
                Id = x.Employeeid,
                Firstname = x.Firstname,
                Lastname = x.Lastname,
                Email = x.Email,
                Phone = x.Phone,
                Department = x.Department.Departmentname
            }).ToListAsync();   
        }

        public async Task<Employee> GetById(int id)
        {
            return await _dbContext.Employees.FirstOrDefaultAsync(x => x.Employeeid == id);
        }
    }
}

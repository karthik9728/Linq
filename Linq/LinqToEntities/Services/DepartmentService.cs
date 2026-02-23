using LinqToEntities.DTO;
using LinqToEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace LinqToEntities.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly EmpManagementContext _dbContext;

        public DepartmentService(EmpManagementContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Department>> Get()
        {
            return await _dbContext.Departments.ToListAsync();
        }

        public async Task<List<DepartmentDto>> GetProjection()
        {
            return await _dbContext.Departments
                .Select(x => new DepartmentDto
                {
                    Name = x.Departmentname,
                    Location = x.Location,
                }).ToListAsync();

        }

        public async Task<List<DepartmentDto>> GetProjectionWithQueryable()
        {
            //var departments = await _dbContext.Departments.ToListAsync();

            //var result = departments
            //    .Select(x => new DepartmentDto
            //    {
            //        Name = x.Departmentname,
            //        Location = x.Location
            //    })
            //    .ToList();

            var departments = _dbContext.Departments.AsQueryable();

            var result = await departments
             .Select(x => new DepartmentDto
             {
                 Name = x.Departmentname,
                 Location = x.Location
             })
             .ToListAsync();

            return result;

        }

        public async Task<List<DepartmentDto>> GetProjection(string name)
        {
            return await _dbContext.Departments
                .Where(x => x.Departmentname.Contains(name))
                .Select(x => new DepartmentDto
                {
                    Name = x.Departmentname,
                    Location = x.Location,
                }).ToListAsync();

        }

        public async Task<Department> GetById(int id)
        {
            return await _dbContext.Departments.FirstOrDefaultAsync(x => x.Departmentid == id);
        }
    }
}

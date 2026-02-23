using LinqToEntities.DTO;
using LinqToEntities.Models;

namespace LinqToEntities.Services
{
    public interface IDepartmentService
    {
        Task<List<Department>> Get();

        Task<List<DepartmentDto>> GetProjection();

        Task<List<DepartmentDto>> GetProjectionWithQueryable();

        Task<List<DepartmentDto>> GetProjection(string name);

        Task<Department> GetById(int id);
   
    }
}

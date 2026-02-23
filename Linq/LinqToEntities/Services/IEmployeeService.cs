using LinqToEntities.DTO;
using LinqToEntities.Models;

namespace LinqToEntities.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> Get();

        Task<List<EmployeeDto>> GetProjection();

        Task<Employee> GetById(int id);
    }
}

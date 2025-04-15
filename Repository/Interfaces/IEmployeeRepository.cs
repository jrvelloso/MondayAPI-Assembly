using Monday.Models;

namespace Monday.Repository.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<List<Employee>> GetAllIncluded();
        Task<Employee> GetByIdIncluded(int id);
        Task<Employee> GetByNifIncluded(string nif);
    }
}
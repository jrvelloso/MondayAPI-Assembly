//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface IEmployeeService
    {
        Task<string> Create(Employee employee);
        Task<string> Delete(int id);
        Task<List<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task<Employee> GetByNIF(string NIF);
        Task<string> Update(Employee employee);
    }
}
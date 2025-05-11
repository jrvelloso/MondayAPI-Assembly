//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface IEmployeeService
    {
        string Create(Employee employee);
        Task<bool> Delete(Employee employee);
        Task<List<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
        string GetEmployeeManager(int NIF);
        Task<bool> Update(Employee employee);
    }
}
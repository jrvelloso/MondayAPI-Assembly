//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface IEmployeeService
    {
        Task<string>Create(Employee employee);
        Task<bool> Delete(Employee employee);
        Task<List<Employee>> GetAll();
        Task<Employee> GetById(int id);
        string GetEmployeeManager(int NIF);
        Task<bool> Update(Employee employee);
    }
}
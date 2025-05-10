//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface ICheckoutService
    {
        string Create(Employee employee);
        string Delete(int id);
        Task<List<Employee>> GetAllEmployee();
        Task<Employee> GetById(int id);
        string GetEmployeeManager(int NIF);
        string Update(Employee employee);
    }
}
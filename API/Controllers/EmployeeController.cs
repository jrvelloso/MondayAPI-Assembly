using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Interface;
using Monday.Repository;
using Monday.Repository.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<Employee> GetById(int id)
        {
            var employee = await _employeeService.GetById(id);            
       
            return employee;         
        }

        [HttpGet]
       
        public async Task<List<Employee>> GetAll()
        {
            var employees = await _employeeService.GetAll();
            return employees.ToList();
        }

        public async Task<string> Create(Employee employee)
        {
            string message = "";
            await _employeeService.Create(employee);

            return message;
        }

        public async Task<bool> Update(Employee employee)
        {
            var existingEmployee = await _employeeService.Update(employee);
            return true;
        }

        public async Task<bool> Delete(Employee employee)
        {
            var existingEmployee = await _employeeService.Delete(employee);
            return true;
        }
    }
}

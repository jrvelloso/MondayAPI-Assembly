using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Interface;

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
        [HttpPost]
        public async Task<string> Create(Employee employee)
        {
            string msg = await _employeeService.Create(employee);
            return msg;
        }

        [HttpGet]
        public async Task<Employee> GetById(int id)
        {
            var employee = await _employeeService.GetById(id);

            return employee;
        }
        [HttpGet("GetByNIF")]
        public async Task<Employee> GetByNIF(string NIF)
        {
            var employee = await _employeeService.GetByNIF(NIF);
            return employee;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Employee>> GetAll()
        {
            var employees = await _employeeService.GetAll();

            return employees;
        }
        [HttpPut]
        public async Task<string> Update(Employee employee)
        {
            string msg = await _employeeService.Update(employee);
            return msg;
        }
        [HttpDelete]
        public async Task<string> Delete(int id)
        {
            string msg = await _employeeService.Delete(id);
            return msg;
        }

    }
}

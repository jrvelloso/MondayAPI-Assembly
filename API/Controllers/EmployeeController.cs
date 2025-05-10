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

        [HttpGet]
        public async Task<Employee> GetById(int id)
        {
            var employee = await _employeeService.GetById(id);

            return employee;
        }
        
        [HttpPut]

        public async Task<Employee> Update(int id) 
        {
            var employeeput= await _employeeService.GetById(id);
            _employeeService.Update(employeeput);

            return employeeput;
        }

        [HttpPost]

        public async Task<string> Create(Employee employee) 
        {
            string post =  _employeeService.Create(employee);

            return post;
        }

        [HttpDelete]

        public async Task<string> Delete(int id)
        {
            string delete;
            var employeedelete = await _employeeService.GetById(id);
            if (employeedelete != null)
            {

                delete = _employeeService.Delete(id);
            }
            else delete = "Employee not found";
            return delete;

        }

        [HttpGetAll]

        public async Task<IEnumerable<Employee>> GetAll() 
        {
            var employeegetall = await _employeeService.GetAllEmployee();

            return employeegetall;
        }





    }
}

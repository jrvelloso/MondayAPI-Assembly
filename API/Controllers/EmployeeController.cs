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
        public async Task<IEnumerable<Employee>> GetById(int id)
        {
            var employee = await _employeeService.GetById(id);

            if (employee == null)
                return (IEnumerable<Employee>)NotFound();
       
            return (IEnumerable<Employee>)employee;
         
        }
    }
}

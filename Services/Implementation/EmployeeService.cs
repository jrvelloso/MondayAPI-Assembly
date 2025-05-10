//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository { get; set; }
        private IAddressService _addressService { get; set; }

        public EmployeeService(IEmployeeRepository employeeRepository, IAddressService addressService)
        {
            _addressService = addressService;
            _employeeRepository = employeeRepository;
        }

        public string GetEmployeeManager(int NIF)
        {
            return "Chuck Norris";
        }

        public async Task<Employee> GetById(int id)
        {
            Employee employees = await _employeeRepository.GetByIdAsync(id);
            return employees;
        }
        public async Task<List<Employee>> GetAllEmployee()
        {
            var _employees = await _employeeRepository.GetAllAsync();
            //foreach (Employee employee in _employees)
            //{
            //    employee.Address = _addressServices.GetAddressById(employee.AddressId);
            //}
            return _employees.ToList();
        }

        public string Create(Employee employee)
        {
            string message = "";

            //string newEmail = firstName.ToLower() + "." + lastName.ToLower() + "@assembly.pt";

            if (!employee.AcceptedRGDPT)
                message += Environment.NewLine + "To be an employee at Assembly you must accept the RGDPD\n";

            //if (string.IsNullOrEmpt( employee.NIB) == 0 || employee.NIF == 0)
            //    message += Environment.NewLine + "Your NIB or NIF are invalid\n";

            //if (message.Length == 0)
            //{
            //    _employeeRepository.CreateNewEmployee(employee);
            //    employee.AddressId = _addressServices.CreateNewAddress(employee.Address);

            //    message = "User created with success";
            //}
            //else
            //    message = "There as one or more errors in your information.\n" + message;

            return message;
        }

        public string Update(Employee employee)
        {

            return "User updated with sucess";
        }

        public string Delete(int id)
        {

            return "User Deleted with success\n";
        }


    }
}

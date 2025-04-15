//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository { get; set; }

        private AddressService _addressServices { get; set; }

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _addressServices = new AddressService();
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> GetManager(string NIF)
        {            
            var employees = await _employeeRepository.GetAllAsync();
          
            Employee employee = employees.FirstOrDefault(e => e.NIF == NIF);

            if (employee == null)
            {
                throw new KeyNotFoundException($"Employee with NIF {NIF} not found.");
            }

            return employee;
        }

        public async Task<Employee> GetById(int id)
        {
            Employee employees = await _employeeRepository.GetByIdAsync(id);
            return employees;
        }
        public async Task<List<Employee>> GetAll()
        {
            var _employees = await _employeeRepository.GetAllAsync();
            //foreach (Employee employee in _employees)
            //{
            //    employee.Address = _addressServices.GetAddressById(employee.AddressId);
            //}
            return _employees.ToList();
        }

        public async Task<string> Create(Employee employee)
        {
            string message = "";

            //string newEmail = firstName.ToLower() + "." + lastName.ToLower() + "@assembly.pt";

            if (!employee.AcceptedRGDPT)
                message += Environment.NewLine + "To be an employee at Assembly you must accept the RGDPD\n";

            if (string.IsNullOrEmpty(employee.NIB) || string.IsNullOrEmpty(employee.NIF))
                message += Environment.NewLine + "Your NIB or NIF are invalid\n";

            if (message.Length == 0)
            {
                await _employeeRepository.AddAsync(employee);

                message = "User created with success";
            }
            else
                message = "There as one or more errors in your information.\n" + message;

            return message;
        }

        public async Task<string> Update(Employee employee)
        {
            Employee updateEmployee = await _employeeRepository.GetByIdAsync(employee.Id);
            if (updateEmployee == null)
            {
                return "User not founded";
            }
            _employeeRepository.Update(updateEmployee);
            return "User updated with sucess";
        }

        public async Task<string> Delete(int id)
        {
            Employee deleteEmployee = await _employeeRepository.GetByIdAsync(id);
            if (deleteEmployee == null)
            {
                return "User not founded";
            }
            _employeeRepository.Delete(deleteEmployee);
            return "User Deleted with success\n";
        }


    }
}

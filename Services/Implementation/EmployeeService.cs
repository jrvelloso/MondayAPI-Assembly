//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Implementation;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;
using System.Threading.Tasks;

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
            Employee employee = await _employeeRepository.GetByIdAsync(id);
            return employee;
        }
        public async Task<IEnumerable<Employee>> GetAll()
        {
            var employees = await _employeeRepository.GetAllAsync();
            return employees.ToList();
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
                await _employeeRepository.SaveAsync();

                message = "User created with success";
            }
            else
                message = "There as one or more errors in your information.\n" + message;

            return message;
        }

        public async Task<bool> Update(Employee employee)
        {
            var existingEmployee = await _employeeRepository.GetByIdAsync(employee.Id);

            if (existingEmployee == null)
                return false;

            _employeeRepository.Update(employee);
            await _employeeRepository.SaveAsync();
            return true;
        }

        public async Task<bool> Delete(Employee employee)
        {
            var existingEmployee = await _employeeRepository.GetByIdAsync(employee.Id);

            if (existingEmployee == null)
                return false;

            _employeeRepository.Delete(employee);
            await _employeeRepository.SaveAsync();
            return true;
        }


    }
}

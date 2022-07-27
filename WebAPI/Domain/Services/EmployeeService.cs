using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Domain.Models.Repositories;

namespace WebAPI.Domain.Models.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        private readonly IDepartmentRepository _departmentRepository;

        public EmployeeService(IEmployeeRepository linkRepository, IDepartmentRepository departmentRepository)
        {
            _employeeRepository = linkRepository;
            _departmentRepository = departmentRepository;
        }

        public async Task<IEnumerable<EmployeeModel>> EmployeeListAsync()
        {
            List<Employee> employees = (List<Employee>)await _employeeRepository.EmployeeListAsync();

            List<Department> departments = (List<Department>)await _departmentRepository.DepartmentListAsync();

            return employees.Select(employe => new EmployeeModel
            {

                Department = _departmentRepository.DepartmentGetByIdAsync(employe.Id).Result.Name,

                Name = string.Format("{0} {1} {2}", employe.Surname, employe.Name, employe.Patronymic),

                Birthday = employe.Birthday,

                DateOfEmployment = employe.DateOfEmployment,

                Salary = employe.Salary
            });
        }

        public async Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            if (employee != null)
            {
                return await _employeeRepository.CreateEmployeeAsync(employee);
            }
            else
            {
                return null;
            }
        }

        public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            if (employee != null)
            {
                return await _employeeRepository.UpdateEmployeeAsync(employee);
            }
            else
            {
                return null;
            }
        }

        public async Task<Employee> DeleteEmployeeAsync(Employee employee)
        {
            if (employee != null)
            {
                return await _employeeRepository.DeleteEmployeeAsync(employee);
            }
            else
            {
                return null;
            }
        }

        public async Task<Employee> EmployeeGetByIdAsync(int id)
        {
            return await _employeeRepository.EmployeeGetByIdAsync(id);
        }
    }
}

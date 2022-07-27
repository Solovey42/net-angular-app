using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Domain.Models.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeModel>> EmployeeListAsync();

        Task<Employee> EmployeeGetByIdAsync(int id);

        Task<Employee> CreateEmployeeAsync(Employee employee);

        Task<Employee> UpdateEmployeeAsync(Employee employee);

        Task<Employee> DeleteEmployeeAsync(Employee employee);
    }
}

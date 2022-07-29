using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.DTO;

namespace WebAPI.Domain.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> EmployeeListAsync();

        Task<Employee> EmployeeGetByIdAsync(int id);

        Task<Employee> CreateEmployeeAsync(Employee employee);

        Task<Employee> UpdateEmployeeAsync(Employee employee);

        Task<Employee> DeleteEmployeeAsync(int id);
    }
}

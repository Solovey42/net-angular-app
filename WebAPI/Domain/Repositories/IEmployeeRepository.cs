using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Domain.Models.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> EmployeeListAsync();

        Task<Employee> EmployeeGetByIdAsync(int id);

        Task<Employee> CreateEmployeeAsync(Employee employee);

        Task<Employee> UpdateEmployeeAsync(Employee employee);

        Task<Employee> DeleteEmployeeAsync(Employee employee);
    }
}

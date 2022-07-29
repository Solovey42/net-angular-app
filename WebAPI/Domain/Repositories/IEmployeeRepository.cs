using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Domain.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> EmployeeListAsync();

        Task<Employee> EmployeeGetByIdAsync(int id);

        Task<Employee> CreateEmployeeAsync(Employee employee);

        Task<Employee> UpdateEmployeeAsync(Employee employee);

        Task<Employee> DeleteEmployeeAsync(int id);
    }
}

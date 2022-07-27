using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Domain.Models.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationContext _applicationContext;

        public EmployeeRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task<IEnumerable<Employee>> EmployeeListAsync()
        {
            return await _applicationContext.Employees.ToListAsync();
        }

        public async Task<Employee> EmployeeGetByIdAsync(int id)
        {
            return await _applicationContext.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            _applicationContext.Employees.Add(employee);
            await _applicationContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            _applicationContext.Employees.Update(employee);
            await _applicationContext.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> DeleteEmployeeAsync(Employee employee)
        {
            _applicationContext.Employees.Update(employee);
            await _applicationContext.SaveChangesAsync();
            return employee;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Repositories
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
            return await _applicationContext.Employees.Include(employee => employee.Department).ToListAsync();
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

        public async Task<Employee> DeleteEmployeeAsync(int id)
        {
            Employee employee = await EmployeeGetByIdAsync(id);
            _applicationContext.Employees.Remove(employee);
            await _applicationContext.SaveChangesAsync();
            return employee;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Domain.Models.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationContext _applicationContext;

        public DepartmentRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public async Task<IEnumerable<Department>> DepartmentListAsync()
        {
            return await _applicationContext.Departments.ToListAsync();
        }

        public async Task<Department> DepartmentGetByIdAsync(int id)
        {
            return await _applicationContext.Departments.FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}

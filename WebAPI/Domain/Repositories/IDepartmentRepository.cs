using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Models;

namespace WebAPI.Domain.Repositories
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> DepartmentListAsync();

        Task<Department> DepartmentGetByIdAsync(int id);
    }
}

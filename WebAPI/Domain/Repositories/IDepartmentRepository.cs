using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Domain.Models.Repositories
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> DepartmentListAsync();

        Task<Department> DepartmentGetByIdAsync(int id);
    }
}

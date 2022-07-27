using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Domain.Models.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> DepartmentListAsync();
    }
}

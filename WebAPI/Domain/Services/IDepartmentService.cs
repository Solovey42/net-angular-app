using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Models;
using WebAPI.DTO;

namespace WebAPI.Domain.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentResult>> DepartmentListAsync();
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Domain.Models;
using WebAPI.Domain.Repositories;
using WebAPI.Domain.Services;
using WebAPI.DTO;

namespace WebAPI.Domain.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<IEnumerable<DepartmentResult>> DepartmentListAsync()
        {
            List<Department> departments = (List<Department>)await _departmentRepository.DepartmentListAsync();

            return departments.Select(department => new DepartmentResult
            {
                Id = department.Id,

                Name = department.Name

            });
        }
    }
}

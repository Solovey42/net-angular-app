using AutoMapper;
using WebAPI.Domain.Models;

namespace WebAPI.DTO
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Employee, EmployeeResult>().ReverseMap();

            CreateMap<Department, DepartmentResult>().ReverseMap();
        }
    }
}

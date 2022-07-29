using AutoMapper;
using System.Text;
using WebAPI.Domain.Models;

namespace WebAPI.DTO
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Employee, EmployeeResult>()
                .ForPath(dest => dest.Department, opt => opt.MapFrom(src => src.Department.Name))
                .ForPath(dest => dest.Name, opt => opt.MapFrom(src => $"{src.Surname} {src.Name} {src.Patronymic}"));

            CreateMap<EmployeeResult, Employee>()
                .ForPath(dest => dest.Department.Name, opt => opt.MapFrom(src => src.Department))
                .ForPath(dest => dest.Surname, opt => opt.MapFrom(src => src.Name.Split()[0]))
                .ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Split()[1]))
                .ForPath(dest => dest.Patronymic, opt => opt.MapFrom(src => src.Name.Split()[2]));

            CreateMap<Department, DepartmentResult>().ReverseMap();
        }
    }
}

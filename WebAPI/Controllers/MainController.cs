using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Domain.Models;
using WebAPI.Domain.Models.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        private readonly ILogger<MainController> _logger;

        private readonly IEmployeeService _employeeService;

        public MainController(ILogger<MainController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeModel>>> Get()
        {
            try
            {
                return new ObjectResult(await _employeeService.EmployeeListAsync());
            }
            catch
            {
                return StatusCode(500);
            }
            /*return _applicationContext.Employees.Select(employe => new EmployeeModel{

                Department = _applicationContext.Departments.FirstOrDefault(department => department.Id == employe.DepartmentId).Name,
                
                Name = string.Format( "{0} {1} {2}", employe.Surname, employe.Name, employe.Patronymic),
                
                Birthday = employe.Birthday,
                
                DateOfEmployment = employe.DateOfEmployment,
                
                Salary = employe.Salary
            });*/
        }
    }
}

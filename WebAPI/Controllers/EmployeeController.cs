using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Services;
using WebAPI.DTO;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("company/employees")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        private readonly IEmployeeService _employeeService;

        private readonly IMapper _mapper;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService, IMapper mapper)
        {
            _logger = logger;
            _employeeService = employeeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeResult>>> Get()
        {
            try
            {
                var employee = _mapper.Map<IEnumerable<EmployeeResult>>(await _employeeService.EmployeeListAsync());
                
                return new ObjectResult(employee);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeResult>> Get(int id)
        {
            try
            {
                return new ObjectResult(await _employeeService.EmployeeGetByIdAsync(id));
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(EmployeeResult employee)
        {

            try
            {
                return new ObjectResult(await _employeeService.CreateEmployeeAsync(_mapper.Map<Employee>(employee)));
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(EmployeeResult employee)
        {
            try
            {
                return new ObjectResult(await _employeeService.UpdateEmployeeAsync(_mapper.Map<Employee>(employee)));
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                return new ObjectResult(await _employeeService.DeleteEmployeeAsync(id));
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
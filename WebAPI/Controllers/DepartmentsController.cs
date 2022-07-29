using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Services;
using WebAPI.DTO;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("company/departments")]
    public class DepartmentsController : ControllerBase
    {
        private readonly ILogger<DepartmentsController> _logger;

        private readonly IDepartmentService _departmentService;

        private readonly IMapper _mapper;

        public DepartmentsController(ILogger<DepartmentsController> logger, IDepartmentService departmentService, IMapper mapper)
        {
            _logger = logger;
            _departmentService = departmentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentResult>>> Get()
        {
            try
            {
                return new ObjectResult(_mapper.Map<IEnumerable<DepartmentResult>>(await _departmentService.DepartmentListAsync()));
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}


using DepartmentStructure.Data.Domain.Modals;
using DepartmentStructure.Data.Shared;
using DepartmentStructure.Service;
using Microsoft.AspNetCore.Mvc;


namespace DepartmentStructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        private readonly DepartmentStructureDbContext _context;
        private readonly IDepartmentService _departmentService;

        public DepartmentController(DepartmentStructureDbContext context,IDepartmentService departmentService)
        {
            _context = context;
            _departmentService = departmentService;

        }
        [HttpGet]
        public IActionResult Get()
        {
            var structure=_departmentService.GetAllDepartmentsWithEmployee(null);
            return Ok(structure);
        }
        [HttpPost]
        public IActionResult Add([FromQuery]int id)
        {
            var result = _departmentService.AddQuentity(id);
            return Ok(result);
        }

    }

}

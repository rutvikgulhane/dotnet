using Microsoft.AspNetCore.Mvc;
using EmployeeManagerReactApp.Models;
namespace EmployeeManagerReactApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeManagerController : ControllerBase
{


    private readonly emp_infoContext _emp_InfoContext;

    public EmployeeManagerController(emp_infoContext emp_InfoContext) {
        _emp_InfoContext = emp_InfoContext;
    }

    private readonly ILogger<EmployeeManagerController> _logger;

    public EmployeeManagerController(ILogger<EmployeeManagerController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("[controller]/GetDepartment")]
    public IActionResult GetDepartment()
    {
       List<Department> deptList = _emp_InfoContext.Departments.ToList();
       return StatusCode(StatusCodes.Status200OK, deptList);  
    }
    
    [HttpGet]
    [Route("[controller]/GetDepartment/{id}")]
    public IActionResult GetDepartment(int id) {
        Department department = _emp_InfoContext.Departments.FirstOrDefault(d => d.Id == id);
        if (department == null)
        {
            return StatusCode(StatusCodes.Status404NotFound);
        }
        return StatusCode(StatusCodes.Status404NotFound, department);
    }

    [HttpPost]
    []        
}
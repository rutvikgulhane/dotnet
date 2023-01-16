using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagerMVC.Models;

namespace EmployeeManagerMVC.Controllers;

public class DepartmentController : Controller
{
    public readonly emp_infoContext _emp_infoContext;

    public DepartmentController(emp_infoContext emp_infoContext) {
        _emp_infoContext = emp_infoContext;
    }

    public IActionResult Index()
    {
        this.ViewData["departments"] = _emp_infoContext.Departments.ToList();
        return View();
    }

    [HttpGet]

    public IActionResult GetDepartment(int id)
    {
        Department department = _emp_infoContext.Departments.Find(id);
        this.ViewData["department"]= department;
        return View();
    }
 
    public ActionResult Create()
    {
        return View();
    }

        // Specify the type of attribute i.e.
        // it will add the record to the database
    [HttpPost]
    public ActionResult Create(int id, string name) {
    _emp_infoContext.Departments.Add(new Department {Id=id, DepartmentName=name});
                // save the changes
    _emp_infoContext.SaveChanges();
    string message = "Created the record successfully";
    return View();
    }

    [HttpPost]
    public ActionResult Delete(int id) {
    _emp_infoContext.Departments.Remove(_emp_infoContext.Departments.Find(id));
                // save the changes
    _emp_infoContext.SaveChanges();
    string message = "Deleted the record successfully";
    return Redirect("/department");
    }

    [HttpPost]
    public ActionResult Edit(int id) {
        Department department = _emp_infoContext.Departments.Find(id);
        this.ViewData["department"] = department;
        return View();
    }
    
    [HttpPost]
    public ActionResult EditForm() {

        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

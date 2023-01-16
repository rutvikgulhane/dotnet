using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagerMVC.Models;

namespace EmployeeManagerMVC.Controllers;

public class EmployeeController : Controller
{
    public readonly emp_infoContext _emp_infoContext;

    public EmployeeController(emp_infoContext emp_infoContext) {
        _emp_infoContext = emp_infoContext;
    }

    [HttpGet]
    public IActionResult Login() {
      return View();
    }

    public IActionResult Login(Employee employee) {
      List<Employee> employees = _emp_infoContext.Employees.ToList();
      foreach (var item in employees)
      {
        if (item.Email == employee.Email && item.Password == employee.Password)
        {
          return RedirectToAction("Index");
        }
      }
      return View();
    }

    public IActionResult Index()
    {
        this.ViewData["employees"] = _emp_infoContext.Employees.ToList();
        return View();
    }

    [HttpGet]
    public IActionResult Create() {
      return View();
    }
    [HttpPost]
    public IActionResult Create(Employee employee) {
      if (ModelState.IsValid)
      {
        var emp = new Employee() {
          Id = employee.Id,
          FirstName = employee.FirstName,
          LastName = employee.LastName,
          Email = employee.Email,
          Gender = employee.Gender,
          Password = employee.Password,
          Deptid = employee.Deptid,
          Jobid = employee.Jobid
        };
        _emp_infoContext.Employees.Add(emp);
        _emp_infoContext.SaveChanges();
        return RedirectToAction("Index");
      } else {
        TempData["error"] = "Empty fields";
        return View(employee);
      }
    }

    public IActionResult Edit(int id) {
      Employee employee = _emp_infoContext.Employees.Find(id);
      
      return View(employee);
    }

    [HttpPost]
    public IActionResult Edit(Employee employee) {
      var emp = new Employee() {
        Id = employee.Id,
        FirstName = employee.FirstName,
        LastName = employee.LastName,
        Email = employee.Email,
        Gender = employee.Gender,
        Password = employee.Password,
        Deptid = employee.Deptid,
        Jobid = employee.Jobid
      };
      _emp_infoContext.Employees.Update(emp);
      _emp_infoContext.SaveChanges();
      return RedirectToAction("Index");
    }

    public IActionResult Delete(int id) {
      _emp_infoContext.Employees.Remove(_emp_infoContext.Employees.Find(id));
      _emp_infoContext.SaveChanges();
      return RedirectToAction("Index");
    }
}
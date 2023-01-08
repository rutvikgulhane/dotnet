using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeeManager.Models;

namespace EmployeeManager.Controllers;

public class AuthorizationCotroller : Controller {
    private readonly Ilogger<AuthorizationCotroller> _logger;

    public AuthorizationCotroller(ILogger<HomeController> logger) {
        _logger = logger;
    }

     public IActionResult Login()
    {

        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult ValidateRegistration(string fname, string email)
    {
        // List<Employee> employees = EmployeeUtils.GetSomeEmployees();

        return Redirect("home/Welcome");

    }

    public IActionResult Welcome(){
        List<Employee> empList = EmployeeUtils.ReadFromFileInList();
        ViewBag.data = empList;
        return View(empList);
    }
}



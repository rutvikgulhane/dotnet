using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeeManager.Models;
using HRManager;

namespace EmployeeManager.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
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
        List<Employee> employees = EmployeeUtils.GetSomeEmployees();
        if (fname!=null && email!=null)
        {
         employees.Add(new Employee() {FirstName=fname, Email=email});
         EmployeeUtils.WriteIntoFileInJson(employees);   
        }
        return Redirect("home/Welcome");

    }

    public IActionResult Welcome(){
        List<Employee> empList = EmployeeUtils.ReadFromFileInList();
        ViewBag.data = empList;
        return View(empList);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RevNRideMVC.Models;
using RevNRideBLL;
using RevNRideBOL;

namespace RevNRideMVC.Controllers;

public class CarsController : Controller
{
    private readonly ILogger<CarsController> _logger;

    public CarsController(ILogger<CarsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Car> cars = CarManager.GetCars();
        this.ViewData["Cars"] = cars;
        return View();
    }

    public IActionResult Car(string id) {
        this.ViewData["car"] = CarManager.GetCar(id);
        return View();
    }


}
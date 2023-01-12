using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RevNRide.Models;
using System.IO;

namespace RevNRide.Controllers;

public class BikesController : Controller
{
    private readonly ILogger<BikesController> _logger;

    public BikesController(ILogger<BikesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["bikeList"] = BikeUtils.ReadBikesFromFile();
        return View();
    }
    public IActionResult Registration_Add()
    {
        return View();
    }
    public IActionResult AddBike(string brand, string name, string model)
    {
        System.Console.WriteLine("--------BikesController.Add() Called--------");
        if (BikeOperations.ValidateBikeDetails(brand, name, model))
        {
            BikeOperations.AddABikeInListAndFile(brand, name, model);
            return Redirect("/Bikes/RegistrationSuccessfull");
        }
        return Redirect("/Bikes/RegistrationUnsuccessfull");
    }
    
    //Find_Bike

    //Registration_Update

    // Delete_Bike
    public IActionResult Delete()
    {
        return View();
    }


    public IActionResult RegistrationSuccessfull()
    {
        return View();
    }
    
    public IActionResult RegistrationUnsuccessfull()
    {
        return View();
    }


}
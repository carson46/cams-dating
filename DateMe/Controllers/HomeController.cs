using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }


    [HttpGet]
    public IActionResult DatingApplication()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult DatingApplication(Application response)
    {
        return View("Confirmation");
    }

   
}
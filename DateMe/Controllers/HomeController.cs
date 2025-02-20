using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers;

public class HomeController : Controller
{
    private DatingApplicationContext _context;
    public HomeController(DatingApplicationContext Date) // Constructor 
    {
        _context = Date;
    }
    public IActionResult Index()
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
        
        _context.Applications.Add(response); // Add record to the database
        _context.SaveChanges();
        return View("Confirmation", response);
    }

    public IActionResult Confirmation(Application response)
    {
        return View(response);
    }

    public IActionResult WaitList()
    {
        // Linq query
        var applications = _context.Applications
            .Where(x => x.Clingy == false)
            .OrderBy(x => x.LastName).ToList();
        return View();
    }

   
}
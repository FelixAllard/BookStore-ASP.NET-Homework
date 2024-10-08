using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineBookstoreAssignment.Models;

namespace OnlineBookstoreAssignment.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    
    public IActionResult Index(string id)
    {
        return View(model : id);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    

    
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
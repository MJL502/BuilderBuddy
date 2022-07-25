using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BuilderBuddy.Models;

namespace BuilderBuddy.Controllers;

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

    public IActionResult GetStarted()
    {
        return View();
    }

    /*
    public IActionResult EditProject()
    {
        return View();
    }

    public IActionResult ArchivedProjects()
    {
        return View();
    }
    */

    public IActionResult Help()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

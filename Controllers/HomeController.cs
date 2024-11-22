using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using stevenscounter.Models;

namespace stevenscounter.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private static int visitors = 0;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
	visitors += 1;
        return View(visitors);
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

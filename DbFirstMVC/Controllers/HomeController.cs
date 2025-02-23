using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DbFirstMVC.Models;

namespace DbFirstMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    // Hi, Ali Ilyas
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Hi, Ali Ilyas
    public IActionResult Index()
    {
        return View();
    }

    // Hi, Ali Ilyas
    public IActionResult Privacy()
    {
        return View();
    }

    // Hi, Ali Ilyas
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

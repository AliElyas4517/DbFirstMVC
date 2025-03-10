using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DbFirstMVC.Models;

namespace DbFirstMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    // Hi, Ali Bhai
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Hi, Ali Bhai
    public IActionResult Index()
    {
        Console.WriteLine("This is Modified Home Controller By Ali Husnain");
        return View();
    }

    // Hi, Ali Bhai
    public IActionResult Privacy()
    {
        Console.WriteLine("This is Modified Home Controller By Ali Husnain");
        return View();
    }

    // Hi, Ali Bhai
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        Console.WriteLine("This is Modified Home Controller By Ali Husnain");
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

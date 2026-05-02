using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KutuphaneMVC.Models;

namespace KutuphaneMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly KutuphaneContext _kutuphane;

    public HomeController(ILogger<HomeController> logger,KutuphaneContext kutuphane)
    {
        _logger = logger;
        this._kutuphane = kutuphane;
    }

    public IActionResult Index()
    {
        return View();
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

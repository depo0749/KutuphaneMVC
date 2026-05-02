using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KutuphaneMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KutuphaneMVC.Controllers
{
    
    public class GKsistemController : Controller
    {
        private readonly ILogger<GKsistemController> _logger;
        private readonly KutuphaneContext _kutuphaneContext;

        public GKsistemController(ILogger<GKsistemController> logger,KutuphaneContext kutuphaneContext)
        {
            _logger = logger;
            this._kutuphaneContext=kutuphaneContext;
        }
         [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(Kullanici model)
        {
            
           return View();
        }
        public IActionResult Giris()
        {
            return View();
        }
        public IActionResult Kayit()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
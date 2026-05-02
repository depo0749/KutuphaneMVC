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
   
    public class GKsistemiController : Controller
    {
        private readonly ILogger<GKsistemiController> _logger;
        private readonly KutuphaneContext _kutuphaneContext;

        public GKsistemiController(ILogger<GKsistemiController> logger,KutuphaneContext kutuphaneContext)
        {
            _logger = logger;
            this._kutuphaneContext = kutuphaneContext;
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
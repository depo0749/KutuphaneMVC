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
   
    public class KullaniciController : Controller
    {
        private readonly ILogger<KullaniciController> _logger;
         private readonly KutuphaneContext _kutuphane;

        public KullaniciController(ILogger<KullaniciController> logger, KutuphaneContext kutuphane)
        {
            _logger = logger;
            this._kutuphane = kutuphane;
        }
        [HttpGet]
         public IActionResult Ekle(   )
        {
            return View(_kutuphane.kullaniciClasses.ToList());
        }
        [HttpPost]
         public IActionResult Ekle( KullaniciClass k)
        {
            return RedirectToAction();
        }
        [HttpGet]
        public IActionResult Giris()
        {
            return View(_kutuphane.kullaniciClasses.ToList());
        }
        [HttpPost]
        public IActionResult Giris(KullaniciClass k)
       {
             return RedirectToAction();
        
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
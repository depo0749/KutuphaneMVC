using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneMVC.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }
        public string? KAd { get; set; }
        public string? KEposta { get; set;}
         public string? KTelefon { get; set;}
         public string? KSifre { get; set;}
    }
}
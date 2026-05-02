using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneMVC.Models
{
    public class KullaniciClass
    {
        [Key]
        public int KId { get; set; }
        public string? KAdi { get; set; }
        public string? KEposta { get; set; }
        public string? KTelefon { get; set; }
        public string? KSifre { get; set; }
        [NotMapped]
        public IFormFile? KResim{ get; set; }
        public string? KKapakFoto{ get; set; }
    }
}
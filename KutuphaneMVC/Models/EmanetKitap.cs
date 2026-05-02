using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneMVC.Models
{
    public class EmanetKitap
    {
        [Key]
        public int EKitapId { get; set; }
        public string? EKullaniciAD{ get; set; }
        public string? EKitapAdi { get; set; }    
         public string? EYazar { get; set; } 
         public int EKitapAdiSayfaSayisi { get; set; }  
          public string? ETur { get; set; } 
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneMVC.Models
{
    public class Mesaj
    {
        [Key]
        public int MId { get; set; }
        public string? MKAd { get; set; }
        public string? MMesaj{ get; set; }
    }
}
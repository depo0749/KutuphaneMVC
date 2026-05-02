using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneMVC.Models
{
    public class Admin
    {
        [Key]
        public int AId { get; set; }
        public string? AAdi { get; set; }
        public string? AEposta { get; set; }
        public string? ATelefon { get; set; }
        public string? ASifre { get; set; }
        [NotMapped]
        public IFormFile? AResim{ get; set; }
        public string? AKapakFoto{ get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneMVC.Models
{
    public class Kitap
    {
         public int Id { get; set; }

  public string? KitapAdi { get; set; }
  public string? YazarAdi { get; set; }
  public string? YayinEvi { get; set; }
  public int StokAdedi { get; set; }
  public string? SayfaSayisi { get; set; }
  public string? Tur{get; set; }

  [NotMapped]
  public IFormFile? Resim{get; set; }
  public DateTime EklemeTarihi { get; set; } = DateTime.Now;
  public string? KapakFoto{ get; set; }
  
    }
}
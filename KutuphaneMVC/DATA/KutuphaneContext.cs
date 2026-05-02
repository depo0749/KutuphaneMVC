using Microsoft.EntityFrameworkCore;

namespace KutuphaneMVC.Models {
    public class KutuphaneContext : DbContext {
        public KutuphaneContext() { }
        public KutuphaneContext(DbContextOptions<KutuphaneContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Kitapdb.db");
            optionsBuilder.UseSqlite("Data Source=Kullanici.db");
            optionsBuilder.UseSqlite("Data Source=Admindb.db");
        }

        public DbSet<Kitap> kitaps { get; set; }
         public DbSet<KullaniciClass> kullaniciClasses { get; set; }
                    public DbSet<Admin> admins { get; set; }

    }
}
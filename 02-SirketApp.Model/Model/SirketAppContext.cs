using _01_SirketApi.Entity.Entity;
using Microsoft.EntityFrameworkCore;

namespace _02_SirketApp.Model.Model
{
    public class SirketAppContext : DbContext
    {
      

        public DbSet<Personel> Personels { get; set; }
        public DbSet<Cocuk> Cocuks { get; set; }
        public DbSet<Gorevlendirme> Gorevlendirmes { get; set; }
        public DbSet<Il> Ils { get; set; }
        public DbSet<Ilce> Ilces { get; set; }
        public DbSet<Birim> Birims { get; set; }
        public DbSet<Proje> Projes { get; set; }
        public DbSet<Unvan> Unvans { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;database=SirketApp;Integrated Security=true;TrustServerCertificate=True;");
        }

    }

}

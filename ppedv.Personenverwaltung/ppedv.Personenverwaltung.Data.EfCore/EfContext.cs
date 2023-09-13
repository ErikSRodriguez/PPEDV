using Microsoft.EntityFrameworkCore;
using ppedv.Personenverwaltung.Contracts;
using System.Diagnostics;

namespace ppedv.Personenverwaltung.Data.EfCore
{
    public class EfContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Land> Lands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conString = "Server=.;Database=Personenverwaltung;Trusted_Connection=True;TrustServerCertificate=true;";
            conString = "Server=(localdb)\\mssqllocaldb;Database=Personenverwaltung;Trusted_Connection=True;TrustServerCertificate=true;";

            optionsBuilder.UseLazyLoadingProxies()
                          .UseSqlServer(conString)
                          .LogTo(x => Debug.WriteLine(x))
                          .EnableSensitiveDataLogging(true);
        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OtelRezervasyon2.Models;
using System.Security.Cryptography.X509Certificates;

namespace OtelRezervasyon2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Fotograf> Fotograf { get; set; }
        public DbSet<Kategori> kategori { get; set; }
        public DbSet<Musteri> musteri { get; set; }
        public DbSet<Otel> Otel { get; set; }
        public DbSet<OtelOlanaklari> otelOlanaklari { get; set; }
        public DbSet<OtelYorum> otelYorum { get; set; }
        public DbSet<Rezervasyon> Rezervasyon { get; set; }
        public DbSet<RezervasyonOdeme> RezervasyonOdeme { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }
    }
}
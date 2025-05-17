using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-2R1QUB5;initial catalog=DesignPattern2;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
    }
}

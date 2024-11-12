using Microsoft.EntityFrameworkCore;


namespace CRUDweb.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-P0KTA4L;Database=Product_CRUD;Trusted_Connection=True;TrustServerCertificate=True;");      
                
        }
    }
}

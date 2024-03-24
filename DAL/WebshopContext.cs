using Microsoft.EntityFrameworkCore;


namespace DAL
{
    public class WebshopContext : DbContext
    {
        public DbSet<Model.BasketPosition> BasketPositions {  get; set; }
        public DbSet<Model.Order> Orders { get; set; }
        public DbSet<Model.OrderPosition> OrderPositions { get; set; }
        public DbSet<Model.Produkt> Produkts { get; set; }
        public DbSet<Model.User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}

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
            optionsBuilder.UseSqlServer("Server=localhost; Database=wojkubDB; Trusted_Connection=True");
        }
    }
}

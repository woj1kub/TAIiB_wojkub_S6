using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Produkt")]
    public class Produkt {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<BasketPosition>? BasketPositions { get; set; }
        public IEnumerable<OrderPosition>? OrderPositions { get; set; }

        public void Configure(EntityTypeBuilder<Produkt> builder)
        {
            builder
            .HasMany(x => x.BasketPositions)
            .WithOne(x => x.Produkt)
            .OnDelete(DeleteBehavior.Cascade); //Uszczegółowienie charakteru relacji

            builder
            .HasMany(x => x.OrderPositions)
            .WithOne(x => x.Produkt)
            .OnDelete(DeleteBehavior.Cascade); //Uszczegółowienie charakteru relacji
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("OrderPosition")]
    public class OrderPosition
    {
        [Key]
        public int ID { get; set; }
        public int OrderID { get; set; }
        [ForeignKey(nameof(OrderID))]
        public Order? Order { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public void Configure(EntityTypeBuilder<Produkt> builder)
        {
            builder
            .HasMany(x => x.BasketPositions)
            .WithOne(x => x.Produkt)
            .OnDelete(DeleteBehavior.SetNull); //Uszczegółowienie charakteru relacji
        }
    }
}

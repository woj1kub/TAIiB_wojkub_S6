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
    [Table("Order")]
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public User? User { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<Model.OrderPosition>? OrderPositions { get; set; }

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
            .HasMany(x => x.OrderPositions)
            .WithOne(x => x.Order)
            .OnDelete(DeleteBehavior.Cascade); //Uszczegółowienie charakteru relacji
            builder
            .HasOne(x => x.User)
            .WithMany(x => x.Orders)
            .OnDelete(DeleteBehavior.SetNull); //Uszczegółowienie charakteru relacji
        }
    }
}

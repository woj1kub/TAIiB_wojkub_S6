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
    [Table("BasketPosition")]
    public class BasketPosition
    {
        [Key]
        public int ID { get; set; }
        public int ProductID { get; set; }
        [ForeignKey(nameof(ProductID))]
        public Produkt? Produkt { get; set; }
        public int UserID { get; set; }
        [ForeignKey(nameof(UserID))]
        public User? User { get; set; }
        public int Amount { get; set; }

        public void Configure(EntityTypeBuilder<BasketPosition> builder)
        {
            builder
            .HasOne(x => x.User)
            .WithMany(x => x.BasketPositions)
            .OnDelete(DeleteBehavior.SetNull); //Uszczegółowienie charakteru relacji
            builder
            .HasOne(x => x.Produkt)
            .WithMany(x => x.BasketPositions)
            .OnDelete(DeleteBehavior.SetNull); //Uszczegółowienie charakteru relacji
        }
    }
}

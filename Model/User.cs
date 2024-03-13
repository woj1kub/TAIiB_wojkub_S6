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
    public enum UserType
    {
        Admin,
        Casual
    }

    [Table("User")]
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public UserType Type { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<Order>? Orders { get; set; }
        public IEnumerable<BasketPosition>? BasketPositions { get; set; }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
            .HasMany(x => x.Orders)
            .WithOne(x => x.User)
            .OnDelete(DeleteBehavior.Cascade); //Uszczegółowienie charakteru relacji
            builder
            .HasMany(x => x.BasketPositions)
            .WithOne(x => x.User)
            .OnDelete(DeleteBehavior.Cascade); //Uszczegółowienie charakteru relacji
        }
    }
}

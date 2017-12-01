using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyStoreWebApi.DL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal OrderPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public ICollection<Product> Products { get; set; }
        public User User { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }
    }

    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Quantity)
                .IsRequired();

            Property(x => x.OrderPrice)
                .HasPrecision(15, 2)
                .IsRequired();

            Property(x => x.OrderDate)
                .IsRequired();

            //HasMany(x => x.Products);
                

            HasRequired(x => x.User);//[ForeignKey]
        }
    }
}

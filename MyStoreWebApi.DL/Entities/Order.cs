using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyStoreWebApi.DL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal OrderPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }
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

            HasRequired(x => x.Product);
            HasRequired(x => x.User);//[ForeignKey]
        }
    }
}

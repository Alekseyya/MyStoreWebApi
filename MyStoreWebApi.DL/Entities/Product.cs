using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyStoreWebApi.DL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public int Count { get; set; }
        public int? MarkId { get; set; }

        public ICollection<Order> Orders { get; set; }
        public Category Category { get; set; }
        public Mark Mark { get; set; }
        public ICollection<Picture> Pictures { get; set; }

        public Product()
        {
            Pictures = new List<Picture>();
            Orders = new List<Order>();
        }
    }
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name)
                .HasMaxLength(250)
                .IsRequired();

            Property(x => x.Descriptions)
                .HasMaxLength(400);

            Property(x => x.Price)
                .HasPrecision(15, 2)
                .IsRequired();

            Property(x => x.Count)
                .IsRequired();

            //HasMany(x => x.Pictures);

            
            HasOptional(x => x.Category); //[ForeignKey]
        }
    }
}

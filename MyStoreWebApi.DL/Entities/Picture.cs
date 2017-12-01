using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MyStoreWebApi.DL.Entities
{
   public class Picture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime UpdateTimestamp { get; set; }
        public int? ProductId { get; set; }
        public Product Product{ get; set; }

    }
    public class PictureConfiguration : EntityTypeConfiguration<Picture>
    {
        public PictureConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name)
                .IsRequired();

            Property(x => x.Path)
                .IsRequired();

            Property(x => x.UpdateTimestamp)
                .IsRequired();

            HasOptional(x => x.Product);
        }
    }
}

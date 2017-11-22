
using System.Data.Entity;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DL.Context
{
    public class MyStoreContext: DbContext
    {
        public MyStoreContext()
            : base("MyStore")
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new PhotoConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
        }

        public class DatabaseInitializer
            : CreateDatabaseIfNotExists<MyStoreContext>
        {
            public override void InitializeDatabase(MyStoreContext context)
            {

            }
        }
    }
}

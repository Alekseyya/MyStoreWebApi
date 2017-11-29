
using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyStoreWebApi.DL.Entities;

namespace MyStoreWebApi.DL.Context
{
    public class MyStoreContext: IdentityDbContext<User, CustomRole, Guid, Login, Role, Claim>
    {
        public MyStoreContext()
            : base("MyStore")
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Mark> Marks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new PhotoConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new ClaimConfiguration());
            modelBuilder.Configurations.Add(new LoginConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new MarkConfiguration());
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

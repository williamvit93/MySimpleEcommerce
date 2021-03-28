using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;
using WaTecnologia.MySimpleEcommerce.Repository.EntityMapping;

namespace WaTecnologia.MySimpleEcommerce.Repository
{
    public class MySimpleEcommerceContext : DbContext
    {
        private string _connectionString;

        public MySimpleEcommerceContext()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();
            _connectionString = configuration.GetConnectionString("MySimpleEcommerceContext");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries<EntityBase>().Where(e => e.State == EntityState.Modified))
            {
                item.Property(nameof(item.Entity.ModifiedDate)).CurrentValue = DateTime.Now;
                item.Property(nameof(item.Entity.CreatedDate)).IsModified = false;
            }

            foreach (var item in ChangeTracker.Entries<EntityBase>().Where(e => e.State == EntityState.Added))
            {
                item.Property(nameof(item.Entity.CreatedDate)).CurrentValue = DateTime.Now;
                
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new ProductPriceMap());
            modelBuilder.ApplyConfiguration(new SaleMap());

            foreach (var property in modelBuilder.Model
                    .GetEntityTypes()
                       .SelectMany(e => e.GetProperties()
                             .Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }
        }
    }
}

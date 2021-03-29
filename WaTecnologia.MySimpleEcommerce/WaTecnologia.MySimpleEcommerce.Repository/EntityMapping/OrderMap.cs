using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;

namespace WaTecnologia.MySimpleEcommerce.Repository.EntityMapping
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(b => b.CreatedDate)
                .IsRequired();

            builder.HasOne(s => s.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(s => s.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(s => s.Products)
                .WithMany(c => c.Orders);

            builder.Navigation(s => s.Products)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            builder.Navigation(s => s.Customer)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            builder.ToTable("Orders");
        }

    }
}

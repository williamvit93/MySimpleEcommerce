using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;

namespace WaTecnologia.MySimpleEcommerce.Repository.EntityMapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(b => b.CreatedDate)
                .IsRequired();

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.HasMany(p => p.ProductPrices)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Navigation(p => p.ProductPrices)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            builder.Navigation(p => p.Orders)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            builder.ToTable("Products");
        }

    }
}

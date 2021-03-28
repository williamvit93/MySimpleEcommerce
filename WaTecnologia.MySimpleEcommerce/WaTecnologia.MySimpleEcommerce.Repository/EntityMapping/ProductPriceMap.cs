using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;

namespace WaTecnologia.MySimpleEcommerce.Repository.EntityMapping
{
    public class ProductPriceMap : IEntityTypeConfiguration<ProductPrice>
    {
        public void Configure(EntityTypeBuilder<ProductPrice> builder)
        {
            builder.HasKey(pp => pp.Id);
            builder.Property(b => b.CreatedDate)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.HasOne(pp => pp.Product)
                .WithMany(prod => prod.ProductPrices)
                .HasForeignKey(pp => pp.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(pp => pp.CreatedDate)
                .IsRequired();

            builder.Navigation(p => p.Product)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            builder.ToTable("ProductPrices");
        }

    }
}

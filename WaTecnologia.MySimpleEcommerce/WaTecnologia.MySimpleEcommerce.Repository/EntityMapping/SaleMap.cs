using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;

namespace WaTecnologia.MySimpleEcommerce.Repository.EntityMapping
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(b => b.CreatedDate)
                .IsRequired();

            builder.HasOne(s => s.Customer)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(s => s.Products)
                .WithMany(c => c.Sales);

            builder.Navigation(s => s.Products)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            builder.Navigation(s => s.Customer)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            builder.ToTable("Sales");
        }

    }
}

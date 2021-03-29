using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WaTecnologia.MySimpleEcommerce.Domain.Entities;

namespace WaTecnologia.MySimpleEcommerce.Repository.EntityMapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(b => b.CreatedDate)
                .IsRequired();

            builder.Property(b => b.BirthDate)
                .IsRequired();

            builder.Property(c => c.FullName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11);

            builder.Navigation(s => s.Orders)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            builder.ToTable("Customer");
        }
    }
}

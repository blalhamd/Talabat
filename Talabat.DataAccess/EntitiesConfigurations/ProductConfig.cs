

namespace Talabat.DataAccess.EntitiesConfigurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products").HasKey(x=> x.Id);

            builder.Property(x=> x.Price)
                   .HasColumnType("decimal")
                   .HasPrecision(10,2)
                   .IsRequired();
        }
    }
}

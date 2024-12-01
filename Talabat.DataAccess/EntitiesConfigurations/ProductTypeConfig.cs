namespace Talabat.DataAccess.EntitiesConfigurations
{
    public class ProductTypeConfig : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.ToTable("ProductTypes").HasKey(x=> x.Id);
        }
    }
}

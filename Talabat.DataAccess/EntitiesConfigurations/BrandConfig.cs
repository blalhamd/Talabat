namespace Talabat.DataAccess.EntitiesConfigurations
{
    public class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands").HasKey(x=> x.Id);
        }
    }
}

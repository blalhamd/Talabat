namespace Talabat.DataAccess.EntitiesConfigurations
{
    public class DeliveryMethodConfig : IEntityTypeConfiguration<DeliveryMethod>
    {
        public void Configure(EntityTypeBuilder<DeliveryMethod> builder)
        {
            builder.ToTable("DeliveryMethods").HasKey(x => x.Id);

            builder.Property(x => x.Cost).HasColumnType("decimal").HasPrecision(10, 2);

        }
    }
}

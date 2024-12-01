namespace Talabat.DataAccess.EntitiesConfigurations
{
    public class OrderItemConfig : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems").HasKey(x => x.Id);

            builder.OwnsOne(x => x.Product);

            builder.Property(x => x.Price).HasColumnType("decimal").HasPrecision(10, 2);

        }
    }
}

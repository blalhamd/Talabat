namespace Talabat.DataAccess.EntitiesConfigurations
{
    public class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders").HasKey(x => x.Id);

            builder.OwnsOne(x => x.ShippingAddress);

            builder.Property(p => p.OrderStatus).HasConversion(
                x => x.ToString(),
                x => (OrderStatus)Enum.Parse(typeof(OrderStatus),x)
                );

            builder.Property(x=> x.SubTotal).HasColumnType("decimal").HasPrecision(10,2);

            builder.HasOne(x => x.DeliveryMethod)
                   .WithMany(x => x.Orders)
                   .HasForeignKey(x => x.DeliveryMethodId)
                   .OnDelete(DeleteBehavior.SetNull);
        }
    }
}

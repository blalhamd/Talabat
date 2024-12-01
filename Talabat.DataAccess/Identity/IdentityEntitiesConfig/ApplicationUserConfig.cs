namespace Talabat.DataAccess.Identity.IdentityEntitiesConfig
{
    public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.OwnsOne(x => x.Address);

            builder.OwnsMany(x => x.RefreshTokens);

            builder.Property(x=> x.FirstName).HasMaxLength(250).IsRequired();
            builder.Property(x=> x.LastName).HasMaxLength(250).IsRequired();

        }
    }
}

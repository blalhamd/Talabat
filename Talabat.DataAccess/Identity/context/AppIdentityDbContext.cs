﻿namespace Talabat.DataAccess.Identity.context
{
    public class AppIdentityDbContext : IdentityDbContext<ApplicationUser, AppRole,int>
    {
        public AppIdentityDbContext()
        {
        }

        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApplicationUserConfig());

            builder.Entity<ApplicationUser>().ToTable(name: "Users", schema: "Security");
            builder.Entity<IdentityUserRole<int>>().ToTable(name: "UserRoles", schema: "Security");
            builder.Entity<AppRole>().ToTable(name: "Roles", schema: "Security");
            builder.Entity<IdentityRoleClaim<int>>().ToTable(name: "RoleClaims", schema: "Security");
            builder.Entity<IdentityUserRole<int>>().ToTable(name: "UserRoles", schema: "Security");
        }
    }
}

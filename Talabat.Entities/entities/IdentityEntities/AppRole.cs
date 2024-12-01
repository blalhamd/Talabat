namespace Talabat.DataAccess.Identity.IdentityEntities
{
    public class AppRole : IdentityRole<int>
    {
        public DateTime CreationTime { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
    }
}

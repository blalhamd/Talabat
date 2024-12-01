namespace Talabat.DataAccess.Identity.IdentityEntities
{
    [Owned]
    [Table(name: "RefreshTokens", Schema = "Security")]
    public class RefreshToken
    {
        public string RefreshTokenValue { get; set; } = null!;
        public DateTime ExpiresOn { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? RevokedOn { get; set; }
        public bool IsExpired => DateTime.UtcNow >= ExpiresOn;
        public bool IsActive => !IsExpired && RevokedOn is null;
        
        [Column(name:"UserId")]
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;
    }
}

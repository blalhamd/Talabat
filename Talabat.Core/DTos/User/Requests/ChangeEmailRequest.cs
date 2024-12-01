namespace Talabat.Core.DTos.User.Requests
{
    public class ChangeEmailRequest
    {
        [Required]
        [EmailAddress]
        public string NewEmail { get; set; } = null!;
    }
}

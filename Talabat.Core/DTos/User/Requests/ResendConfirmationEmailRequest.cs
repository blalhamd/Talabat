namespace Talabat.Core.DTos.User.Requests
{
    public class ResendConfirmationEmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
    }
}

namespace Talabat.Core.DTos.Authentication.Requests
{
    public class RefreshTokenRequest
    {
        [Required]
        public string AccessToken { get; set; } = null!;

        [Required]
        public string RefreshToken { get; set;} = null!;
    }
}

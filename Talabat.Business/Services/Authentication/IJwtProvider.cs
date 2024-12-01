namespace Talabat.Business.Services.Authentication
{
    public interface IJwtProvider
    {
        JwtProviderResponse GenerateToken(ApplicationUser applicationUser,IEnumerable<string> roles,IEnumerable<string> permissions); // will need user for claims(NameIdentifier,Email,GivenName,Name) that exist in Subject that exist in SecurityTokenDescriptor
        string? ValidateToken(string jwtToken);
    }
}

﻿namespace Talabat.Core.DTos.Authentication.Responses
{
    public class LoginResponse
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Email { get; set; } 
        public string Token { get; set; } = null!;
        public int ExpireIn { get; set; }
        public string RefreshToken { get; set; } = null!;
        public DateTime RefreshTokenExpiration { get; set; }
    }
}

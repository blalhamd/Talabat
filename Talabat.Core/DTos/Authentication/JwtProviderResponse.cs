﻿namespace Talabat.Core.DTos.Authentication
{
    public class JwtProviderResponse
    {
        public string Token { get; set; } = null!;
        public int ExpireIn { get; set; }
    }
}

﻿namespace Talabat.Core.DTos.Authentication.Requests
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
       
        [Required]
        [MinLength(8, ErrorMessage = Errors.PasswordMinLength)]
        [RegularExpression(RegexPatterns.PasswordPattern, ErrorMessage = Errors.PasswordRegExp)]
        public string Password { get; set; } = null!;
    }
}

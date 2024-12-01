﻿namespace Talabat.Core.DTos.User.Requests
{
    public class ResetPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [MinLength(8, ErrorMessage = Errors.PasswordMinLength)]
        [Display(Name = "New Password")]
        [RegularExpression(RegexPatterns.PasswordPattern, ErrorMessage = Errors.PasswordRegExp)]
        public string NewPassword { get; set; } = null!;

        [Required]
        [Compare("NewPassword")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        public string code { get; set; } = null!;
    }
}

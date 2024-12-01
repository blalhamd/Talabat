﻿namespace Talabat.Core.DTos.User.Requests
{
    public class UpdateUserProfile // I didn't add email because I will add change email method and because I applied confirmation email, so if did't apply confirmation email can add email with model 
    {
        [Required]
        [RegularExpression(RegexPatterns.NamePattern, ErrorMessage = Errors.NameRegExp)]
        public string FirstName { get; set; } = null!;

        [Required]
        [RegularExpression(RegexPatterns.NamePattern, ErrorMessage = Errors.NameRegExp)]
        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;
    }
}

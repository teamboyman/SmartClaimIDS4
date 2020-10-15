using SmartClaim.STS.Identity.Configuration;
using System.ComponentModel.DataAnnotations;
using SmartClaim.Shared.Configuration.Identity;

namespace SmartClaim.STS.Identity.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        public LoginResolutionPolicy? Policy { get; set; }
        //[Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Username { get; set; }
    }
}







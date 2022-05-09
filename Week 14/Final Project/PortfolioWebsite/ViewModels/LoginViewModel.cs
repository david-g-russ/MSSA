using System.ComponentModel.DataAnnotations;

namespace PortfolioWebsite.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}

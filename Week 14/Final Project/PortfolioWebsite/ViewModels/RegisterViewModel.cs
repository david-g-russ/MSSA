using System.ComponentModel.DataAnnotations;

namespace PortfolioWebsite.ViewModels
{
    public class RegisterViewModel : LoginViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }
    }
}

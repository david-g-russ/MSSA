using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using PortfolioWebsite.Models;
using System.Threading.Tasks;
using PortfolioWebsite.ViewModels;

namespace PortfolioWebsite.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<User> _signInManager;
        private UserManager<User> _userManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Project");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, loginViewModel.RememberMe, false);
                if (result.Succeeded)
                    return RedirectToAction("Index", "Project");
            }
            ModelState.AddModelError("", "Failed to login");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                User newuser = new()
                {
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                    UserName = registerViewModel.UserName
                };
                var result = await _userManager.CreateAsync(newuser, registerViewModel.Password);
                if (result.Succeeded)
                {
                    var addedUser = await _userManager.FindByNameAsync(newuser.UserName);
                    if (addedUser.UserName == "Admin")
                    {
                        await _userManager.AddToRoleAsync(addedUser, "Admin");
                    }
                    else
                        await _userManager.AddToRoleAsync(addedUser, "Guest");
                    return RedirectToAction("Login", "Account");
                }
                foreach (var error in result.Errors)
                    ModelState.AddModelError("", error.Description);
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

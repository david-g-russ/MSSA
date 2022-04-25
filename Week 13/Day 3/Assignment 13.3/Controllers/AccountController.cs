using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Assignment_13._3.Models;
using System.Threading.Tasks;
using Assignment_13._3.ViewModels;

namespace Assignment_13._3.Controllers
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
                return RedirectToAction("DisplayAll", "Product");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginViewModel.UserName,loginViewModel.Password,loginViewModel.RememberMe,false);
                if (result.Succeeded)
                    return RedirectToAction("DisplayAll", "Product");
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
                    Email = registerViewModel.Email,
                    PhoneNumber = registerViewModel.PhoneNumber,
                    UserName = registerViewModel.UserName
                };
                var result = await _userManager.CreateAsync(newuser,registerViewModel.Password);
                if (result.Succeeded)
                {
                    var addedUser = await _userManager.FindByNameAsync(newuser.UserName);
                    if (addedUser.UserName == "Admin")
                    {
                        await _userManager.AddToRoleAsync(addedUser, "Admin");
                        await _userManager.AddToRoleAsync(addedUser, "Customer");
                    }
                    else
                        await _userManager.AddToRoleAsync(addedUser, "Customer");
                    return RedirectToAction("Login", "Account");
                }
                foreach(var error in result.Errors)
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

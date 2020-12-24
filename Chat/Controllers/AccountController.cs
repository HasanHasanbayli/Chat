using Chat.Models;
using Chat.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Chat.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();
            AppUser appUser = await _userManager.FindByEmailAsync(login.Email);
            if (appUser == null)
            {
                ModelState.AddModelError("", "Email or Password is wrong!!");
                return View(login);
            }

            if (!appUser.IsActivated)
            {
                ModelState.AddModelError("", "Profile is Disabled!!");
                return View(login);
            }

            var signinResult = await _signInManager.PasswordSignInAsync(appUser, login.Password, true, true);

            if (!signinResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is wrong!!");
                return View(login);
            }
            if (signinResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Profile is locked Out");
                return View(login);
            }
            //var role = (await _userManager.GetRolesAsync(appUser))[0];
            //if (role == "Admin")
            //{
            //    return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            //}
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();
            AppUser newUser = new AppUser
            {
                UserName = register.UserName,
                Email = register.Email,
                IsActivated = true
            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
            //await _userManager.AddToRoleAsync(newUser, "Member");
            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }
    }
}
using Chat.DAL;
using Chat.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly IWebHostEnvironment _env;
        public ProfileController(AppDbContext db,
                UserManager<AppUser> userManager,
                IWebHostEnvironment env)
        {
            _env = env;
            _db = db;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return RedirectToAction("Index", "Error");
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(AppUser user)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser exitsUser = await _userManager.FindByNameAsync(User.Identity.Name);
                exitsUser.FirstName = user.FirstName;
                exitsUser.LastName = user.LastName;
                exitsUser.Birthdate = user.Birthdate;
                exitsUser.Email = user.Email;
                exitsUser.NormalizedEmail = user.Email;
                exitsUser.PhoneNumber = user.PhoneNumber;
                exitsUser.WebSite = user.WebSite;
                exitsUser.Address = user.Address;
                exitsUser.Facebook = user.Facebook;
                exitsUser.Twitter = user.Twitter;
                exitsUser.Instagram = user.Instagram;
                exitsUser.Linkedin = user.Linkedin;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
       
    }
}

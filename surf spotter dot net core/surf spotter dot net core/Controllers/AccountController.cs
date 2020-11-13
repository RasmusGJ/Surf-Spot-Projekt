using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using surf_spotter_dot_net_core.Models;
using surf_spotter_dot_net_core.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace surf_spotter_dot_net_core.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;


        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [Route("Login")]
        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }


        [HttpPost, Route("Login")]
        public async Task<ActionResult> Login(LoginViewModel login, string returnUrl = null)
        {
            if (!ModelState.IsValid)
                return View(login);

            var result = await _signInManager.PasswordSignInAsync(
                login.UserName, login.Password,
                login.RememberMe, false
                );

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Login error!");
                return View();
            }
            if (string.IsNullOrWhiteSpace(returnUrl))
                return RedirectToAction("Index", "Home");

            return Redirect(returnUrl);
        }

        [HttpPost]
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();

            if(string.IsNullOrWhiteSpace(returnUrl))
                return RedirectToAction("Index");

            return Redirect(returnUrl);
        }

        [Route("Signup")]
        public IActionResult SignUp()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost, Route("Signup")]
        public async Task<IActionResult> SignUp(RegisterViewModel registration)
        {
            if (!ModelState.IsValid)
                return View(registration);

            var newUser = new IdentityUser
            {
                Email = registration.Email,
                UserName = registration.UserName
            };

            var result = await _userManager.CreateAsync(newUser, registration.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors.Select(x => x.Description))
                {
                    ModelState.AddModelError("", error);
                }
                return View();
            }

            return RedirectToAction("Login");             
        }
    }
}

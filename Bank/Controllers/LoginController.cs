using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bank.Models;
using Bank.ViewModels;
using Microsoft.AspNetCore.Identity;
using Bank.Utils;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Bank.Contexts;
using Bank.Services;
using Microsoft.Extensions.Configuration;


namespace Bank.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private UserManager<Worker> _userManager;
        private SignInManager<Worker> _signInManager;
        private PasswordUtil _pu;

        public LoginController(ILogger<LoginController> logger, UserManager<Worker> userManager, SignInManager<Worker> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _pu = new PasswordUtil();
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> ConfirmLogin(WorkerViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.Login, _pu.GetPasswordHash(viewModel.Password), true, false);
                if(result.Succeeded)
                {
                    var worker = await _userManager.FindByEmailAsync(viewModel.Login);
                    await Authenticate(viewModel.Login);

                    return RedirectToAction("Account", "Account");
                }
                else
                    ModelState.AddModelError("", "Invalid email and / or password");
            }
            return View("Index", viewModel);
        }

        private async Task Authenticate(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}

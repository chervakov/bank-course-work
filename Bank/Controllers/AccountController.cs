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
    public class AccountController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private UserManager<Worker> _userManager;
        private SignInManager<Worker> _signInManager;
        private readonly EmailService _emailService;
        private readonly IConfiguration _config;

        public AccountController(ILogger<LoginController> logger, UserManager<Worker> userManager, SignInManager<Worker> signInManager, 
                                    EmailService emailService, IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailService = emailService;
            _config = config;
        }

        [HttpGet]
        public async Task<IActionResult> Account()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            return View(user);
        }
    }
}
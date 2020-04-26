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
    public class HomeController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private UserManager<Worker> _userManager;
        private readonly EmailService _emailService;
        private readonly IConfiguration _config;

        private PasswordUtil _pu;

        public HomeController(ILogger<LoginController> logger, UserManager<Worker> userManager, 
                                    EmailService emailService, IConfiguration config)
        {
            _userManager = userManager;
            _logger = logger;
            _emailService = emailService;
            _config = config;
            _pu = new PasswordUtil();
            var worker = _userManager.FindByEmailAsync(_config["admin_email"]);
            if(worker.Result == null)
            {
                PasswordUtil pu = new PasswordUtil();
                string password = pu.GetPassword();
                Worker admin = new Worker{
                    Name = _config["admin_name"],
                    Surname = _config["admin_surname"],
                    Email = _config["admin_email"],
                    PasswordHash = pu.GetPasswordHash(password),
                    Role = _config["admin_role"]
                };
                admin.UserName = admin.Email;
                var task = Task.Run(async () =>
                {
                    using(var es = _emailService.SendEmailAsync(admin.Email, "You have been registered in bank system.", $"Login: {admin.Email}\nPassword: {password}")){
                        await es;
                    }
                });
                _userManager.CreateAsync(admin, admin.PasswordHash);
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
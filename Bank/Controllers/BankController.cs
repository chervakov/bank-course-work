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
    public class BankController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private UserManager<Worker> _userManager;
        private SignInManager<Worker> _signInManager;
        private readonly EmailService _emailService;
        private readonly IConfiguration _config;

        private readonly BankDbContext _context;

        public BankController(ILogger<LoginController> logger, UserManager<Worker> userManager, SignInManager<Worker> signInManager, 
                                    EmailService emailService, IConfiguration config, BankDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailService = emailService;
            _config = config;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Clients()
        {
            List<Client> clients = await _context.GetAllClients();
            ClientsViewModel viewModel = new ClientsViewModel{
                Clients = clients
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOneClient(ClientViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                Client client = new Client{
                    Name = viewModel.Name,
                    Surname = viewModel.Surname,
                    PassportNum = viewModel.PassportNum,
                    PassportSeries = viewModel.PassportSeries,
                    Adress = viewModel.Adress,
                    Email = viewModel.Email
                };
                await _context.AddClient(client);
                return RedirectToAction("Clients", "Bank");
            }
            else
            {
                return View("CreateClient" ,viewModel);
            }
        }

        public IActionResult CreateClient()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ClientProfile(int id)
        {
            Client client = await _context.GetClientById(id);
            ClientViewModel viewModel = new ClientViewModel{
                Id = id,
                Name = client.Name,
                Surname = client.Surname,
                Adress = client.Adress,
                PassportNum = client.PassportNum,
                PassportSeries = client.PassportSeries,
                Email = client.Email,
                Deposits = await _context.GetUserDeposits(id),
                Credits = await _context.GetUserCredits(id)
            };
            
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult EditClient(ClientViewModel viewModel, int id)
        {
            if(ModelState.IsValid)
            {
                Client client = new Client{
                    Id = id,
                    Name = viewModel.Name,
                    Surname = viewModel.Surname,
                    PassportNum = viewModel.PassportNum,
                    PassportSeries = viewModel.PassportSeries,
                    Adress = viewModel.Adress,
                    Email = viewModel.Email
                };
                _context.UpdateClient(client);
                return RedirectToAction("Clients", "Bank");
            }
            return RedirectToAction("ClientProfile", viewModel);
        }

        [HttpPost]
        public IActionResult DeleteClient(ClientViewModel viewModel, int id)
        {
            Client client = new Client{
                Id = id,
                Name = viewModel.Name,
                Surname = viewModel.Surname,
                PassportNum = viewModel.PassportNum,
                PassportSeries = viewModel.PassportSeries,
                Adress = viewModel.Adress,
                Email = viewModel.Email,
                Deleted = true
            };
            _context.UpdateClient(client);
            return RedirectToAction("Clients", "Bank");
        }

        [HttpPost]
        public async Task<IActionResult> CreateDeposit(int id)
        {
            Deposit dep = new Deposit{
                IdClient = id,
                Amount = 100,
                Percent = 20
            };
            await _context.AddDeposit(dep);
            return RedirectToAction("Clients", "Bank");
        }

        [HttpPost]
        public async Task<IActionResult> CreateCredit(int id)
        {
            Credit cr = new Credit{
                IdClient = id,
                Amount = 3000,
                Percent = 10,
                Time = 12
            };
            await _context.AddCredit(cr);
            return RedirectToAction("Clients", "Bank");
        }
    } 
}
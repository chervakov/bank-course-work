using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Bank.Models;

namespace Bank.ViewModels
{
    public class DepositViewModel
    {
        public List<Deposit> Deposits{get; set;}
    }
}
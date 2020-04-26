using Bank.Models;
using System;

namespace Bank.Models
{
    public class Deposit
    {
        public int Id{get; set;}
        public int IdClient{get; set;}
        public int Amount {get; set;}
        public int Percent {get; set;}
        public bool Closed {get; set;}
    }
}
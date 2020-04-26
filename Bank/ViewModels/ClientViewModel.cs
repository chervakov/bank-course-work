using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Bank.Models;

namespace Bank.ViewModels
{
    public class ClientViewModel
    {
        [Display(Name = "ID")]
        [ScaffoldColumn(false)]
        public int Id;
        [Required]
        [Display(Name = "Name")]
        public string Name {get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string Surname {get; set;}

        [Required]
        [Display(Name = "Passport number")]
        public int PassportNum {get; set;}

        [Required]
        [Display(Name = "Passport series")]
        [StringLength(10, ErrorMessage = "Adress must be at least 2 characters", MinimumLength = 2)]
        public string PassportSeries {get;set;}

        [Required]
        [Display(Name = "Adress")]
        [StringLength(100, ErrorMessage = "Adress must be at least 10 characters", MinimumLength = 10)]
        public string Adress {get; set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email{get; set;}

        public List<Deposit> Deposits;
        public List<Credit> Credits;
    }
}
using System.ComponentModel.DataAnnotations;

namespace Bank.ViewModels
{
    public class WorkerViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Login{get; set;}

        [Required]
        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "Password must be at least 6 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password{get; set;}
    }
}
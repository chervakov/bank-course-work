namespace Bank.Models
{
    public class Client
    {
        public int Id{get; set;}
        public string Name {get; set; }
        public string Surname {get; set;}
        public int PassportNum {get; set;}
        public string PassportSeries {get;set;}
        public string Adress {get; set;}
        public string Email{get; set;}
        public bool Deleted{get; set;}
    }
}
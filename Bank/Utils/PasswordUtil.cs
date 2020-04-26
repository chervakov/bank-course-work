using System;
using System.Security.Cryptography;
using System.Text;

namespace Bank.Utils
{
    public class PasswordUtil
    {
        private string AlphAndNums = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        public string GetPassword()
        {
            Random rnd = new Random();
            string Password = "";
 
            for (int i = 0; i < 16; i++)
            {
                Password += AlphAndNums[rnd.Next(0, AlphAndNums.Length - 1)];
            }
            return Password;
        }

        public string GetPasswordHash(string password)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
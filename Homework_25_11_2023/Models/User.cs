

using Homework_25_11_2023.Interfaces;

namespace Homework_25_11_2023.Models
{
    public class User : IAccount
    {
        private static int IdCounter = 1;
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string fullname, string email, string password)
        {
            Id = IdCounter++;
            Fullname = fullname;
            Email = email;

       
        }
        public bool PasswordChecker(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                return false;
            }

            return true;
        }
        public void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Id : {Id}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"FullName : {Fullname}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Email : {Email}");
            Console.ResetColor();
        }
    }
}

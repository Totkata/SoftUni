using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!TheLenghtIsValid(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!PasswordIsCorrect(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!ContainsTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (TheLenghtIsValid(password) 
                && PasswordIsCorrect(password)
                && ContainsTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool TheLenghtIsValid(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
        static bool PasswordIsCorrect (string password)
        {
            bool validation = true;
            foreach (char item in password)
            {
                bool valid = Char.IsLetterOrDigit(item);
                if (!valid)
                {
                    validation = false;
                    break;
                }
            }
            if (validation == true)
            {
                return  true;
            }
            return false;
        }
        static bool ContainsTwoDigits (string password)
        {
            int digitCount = 0;
            foreach (char item in password)
            {
                bool valid = Char.IsDigit(item);
                if (valid)
                {
                    digitCount++;
                }
            }
            if (digitCount >= 2)
            {
                return true;
            }
            return false;
        }
    }
}

using System;
namespace PasswordStrengthChecker
{
    class PasswordStrengthChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            //  Console.WriteLine(password);
            CheckStrength(password);
            Console.ReadLine();
        }
        static void CheckStrength(string password)
        {
            int length = password.Length;
            if (length < 8)
            {
                Console.WriteLine(" Password is Very weak");
            }
            else
            {
                bool hasUpper = false;
                bool hasLower = false;
                bool hasSpecial = false;
                bool hasDigit = false;
                string specialChars = "!@#$%&*";
                int score = 0;
                string message = "";
                foreach (char c in password)
                {
                    if (char.IsLower(c)) hasLower = true;
                    else if (char.IsUpper(c)) hasUpper = true;
                    else if (char.IsDigit(c)) hasDigit = true;
                    else if (specialChars.Contains(c)) hasSpecial = true;
                }
                if (hasLower) score++;
                if (hasUpper) score++;
                if (hasDigit) score++;
                if (hasSpecial) score++;

                if (score == 4)
                {
                    message = "Password is very Strong";
                }
                else if (score == 3)
                {
                    message = "Password is storng";
                }
                else if (score == 2)
                {
                    message = "Password is medium";
                }
                else if (score == 1)
                {
                    message = "Password is easy";
                }
                Console.WriteLine($"Password : {password} is {message} {score}");
            }
        }
    }
}
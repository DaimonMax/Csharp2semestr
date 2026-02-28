using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Ex6
    {
        internal static void RunEx6()
        {
            Validator validatorPassword = GetValidator(8);
            Validator validatorLogin = GetValidator(3);

            Console.WriteLine("Password: ");
            string? password = Console.ReadLine();
            Console.WriteLine("Login: ");
            string? login = Console.ReadLine();

            Console.WriteLine($"{validatorPassword(password ?? string.Empty)}");
            Console.WriteLine($"{validatorLogin(login ?? string.Empty)}");
        }

        private delegate bool Validator(string input);

        private static Validator GetValidator(int minLength)
        {
            return input => input.Length > minLength;
        }

    }
}

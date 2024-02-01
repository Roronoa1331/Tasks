using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (password.Length >= 8)
            {
                bool UpperCase = false, LowerCase = false, Number = false, SpecialChar = false;

                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        UpperCase = true;
                        break;
                    }
                }
                foreach (char c in password)
                {
                    if (char.IsLower(c))
                    {
                        LowerCase = true;
                        break;
                    }
                }
                foreach (char c in password)
                {
                    if (char.IsDigit(c))
                    {
                        Number = true;
                        break;
                    }
                }
                foreach (char c in password)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        SpecialChar = true;
                        break;
                    }
                }
                if (UpperCase && LowerCase && Number && SpecialChar) {
                    Console.WriteLine("Password meets all the security requirement");
                }
                else
                {
                    Console.WriteLine("Password doesn`t meet all the security requirement");
                }
            }
            else {
                Console.WriteLine("Password must be at least 8 characters long.");
        } }
    }
}

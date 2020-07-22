using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            Console.WriteLine($"Your username is { user.FirstName.Substring(0,8) }{ user.LastName }");
        }
    }
}

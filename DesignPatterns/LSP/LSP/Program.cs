using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new Manager();

            accountingVP.FirstName = "chandini";
            accountingVP.LastName = "k";
            accountingVP.CalculatePerHourRate(4);

            IManaged emp = new Manager();

            emp.FirstName = "suma";
            emp.LastName = "B";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}

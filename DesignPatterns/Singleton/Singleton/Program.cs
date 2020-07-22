using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singletondemo singletondemo = Singletondemo.GetInstance;
            singletondemo.Add(2,4);
            Singletondemo singletondemo1 = Singletondemo.GetInstance;
            singletondemo1.PrintDetails("Example using Singleton Desing pattern");
            Singletondemo singletondemo2 = Singletondemo.GetInstance;
            Console.WriteLine("Enter firstname and lastname");
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            singletondemo2.EnterDetails(firstname,lastname);

        }
    }
}

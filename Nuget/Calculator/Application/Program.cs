using System;
using Sample;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal=new Calculate();
            Console.WriteLine(string.Format("Add two numbers : {0} ",cal.Add(4,5)));
            Console.WriteLine(string.Format("Subtract two numbers : {0}",cal.Subtract(6,5)));
            Console.WriteLine(string.Format("Multiplication two numbers : {0}",cal.Multiplication(4,5)));
        }
    }
}

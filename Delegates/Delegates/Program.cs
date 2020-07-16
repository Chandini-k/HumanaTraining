using System;
using System.Security.Cryptography.X509Certificates;

namespace Delegates
{
    class Program
    {
        public delegate void TestDelegate(int x,int y);
        static void Main(string[] args)
        {
            TestDelegate testDelegate1 =Add;
            TestDelegate testDelegate2 = Mul;
            testDelegate1(2, 4);
            testDelegate2(2, 2);
        }
        public static void Add(int a, int b)
        {
            Console.WriteLine("Adding Two Number " + (a + b));
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine("Adding Two Number " + (a * b));
        }
    }
}

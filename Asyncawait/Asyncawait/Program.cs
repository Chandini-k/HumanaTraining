using System;
using System.Threading.Tasks;

namespace Asyncawait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var work1 = Add();
            var work2 = Add1();
            await Task.WhenAll(work1,work2);
            Console.ReadLine();
        }
        public static async Task Add()
        {
            Console.WriteLine("Work Started " + DateTime.Now);
            await Work.Ten_Seconds_Task_Async();
            Console.WriteLine("Work Started " + DateTime.Now);
        }
        public static async Task Add1()
        {
            Console.WriteLine("Work Started " + DateTime.Now);
            await Work.Three_Seconds_Task_Async();
            Console.WriteLine("Work Started " + DateTime.Now);
        }
    }
}

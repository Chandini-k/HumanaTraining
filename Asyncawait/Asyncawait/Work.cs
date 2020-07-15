using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asyncawait
{
    class Work
    {
        public static async Task Three_Seconds_Task_Async()
        {
            var task4watch = new Stopwatch();
            task4watch.Start();
            Thread.Sleep(3000);
            task4watch.Stop();
        }
        public static async Task Ten_Seconds_Task_Async()
        {
            var task4watch = new Stopwatch();
            task4watch.Start();
            Thread.Sleep(10000);
            task4watch.Stop();
           
        }
    }
}

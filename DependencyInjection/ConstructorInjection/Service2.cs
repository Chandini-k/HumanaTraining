using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInjection
{
    public class Service2 : IService
    {
        public void Serve() { Console.WriteLine("Service1 Called"); }
    }
}

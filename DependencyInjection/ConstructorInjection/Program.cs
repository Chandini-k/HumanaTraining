using System;

namespace ConstructorInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object
            Service1 s1 = new Service1();
            //passing dependency
            Client c1 = new Client(s1);
            Service2 s2 = new Service2();
            Client c2 = new Client(s2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Singletondemo
    {
        private static int count = 0;
        private static readonly object padlock = new object();
        private static Singletondemo instance = null;
        private static Singletondemo instance1 = null;
        public static Singletondemo GetInstance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Singletondemo();
                   
                }
                return instance;
            }
        }
        public static Singletondemo Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance1 == null)
                    {
                        instance1 = new Singletondemo();
                    }
                    return instance1;
                }
            }
        }
        //to know how many instances created
        private Singletondemo()
        {
            count++;
            Console.WriteLine("Count value " + count.ToString());
        }
        public void Add(int a,int b)
        {
            Console.WriteLine("Adding two number "+(a+b));
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
        public void EnterDetails(string fname,string lname)
        {
            Console.WriteLine("FIRSTNAME : "+fname+"\nLASTNAME : "+lname);
        }
    }
}

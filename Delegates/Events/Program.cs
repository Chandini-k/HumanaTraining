using System;

namespace Events
{
    class Program
    {
        public delegate int Delegate(int a, int b);
        class EventProgram
        {
            event Delegate myEvent;
            public EventProgram()
            {
                this.myEvent += new Delegate(this.Add);
            }
            public int Add(int a,int b)
            {
                return a + b;
            }
            static void Main(string[] args)
            {
                EventProgram eventProgram = new EventProgram();
                int result = eventProgram.myEvent(2, 2);
                Console.WriteLine("Adding no: " + result);
            }

        }
    }
}

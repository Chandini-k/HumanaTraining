using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreEqual("Tod", "Vachev"));
            Console.WriteLine(AreEqual(5, 5));
            Console.WriteLine(AreEqual(true, false));
            Console.WriteLine(new string('-', 40));
            int[] a = new int[] {2,1,3,6,5,9,8};
            Console.WriteLine(string.Join(", ", Sort(a)));

        }
        public static bool AreEqual<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) == 0;
        }
        public static T[] Sort<T>(T[] c) where T : IComparable<T>
        {
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = i + 1; j < c.Length; j++)
                {
                    if (c[i].CompareTo(c[j]) > 0)
                    {
                        T temp = c[i];
                        c[i] = c[j];
                        c[j] = temp;
                    }
                }
            }
            return c;
        }
    }
}

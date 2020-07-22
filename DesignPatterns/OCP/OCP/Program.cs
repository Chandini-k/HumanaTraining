using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee emp1 = new PermanentEmployee(1, "chandini");
            TemporaryEmployee emp2 = new TemporaryEmployee(2, "suma");
            Console.WriteLine(string.Format("Employee Details: {0} \n Employee Bonus : {1}", emp1.ToString(), emp1.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee Details: {0} \n Employee Bonus : {1}", emp2.ToString(), emp2.CalculateBonus(100000).ToString()));
            Console.ReadLine();
        }
    }
}

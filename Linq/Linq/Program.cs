using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 multiples
            List<int> numbers =new List<int> { 5, 6, 30, 2, 10, 5, 6, 45,25 };
            List<int> mul = numbers.Where(x => x % 5 == 0).ToList();
            foreach(var i in mul)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new string('-', 40));
            List<string> names = new List<string> { "chandu", "suma", "valli" };
            List<string> frnds = names.Select(x => x.ToUpper()).ToList();
            foreach (var i in frnds)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new string('-', 40));
            List<Student> students = new List<Student>
            {
                new Student{sid=25,sName="chandini",age=22,classname="btech",avgMarks=95},
                new Student{sid=28,sName="suma",age=21,classname="btech",avgMarks=94},
                new Student{sid=29,sName="valli",age=24,classname="btech",avgMarks=97}
            };
            var stuName = students.First(x => x.avgMarks > 96);
            Console.WriteLine(stuName.sName);
            var stu = students.SingleOrDefault(x=>x.sid<24);
            if (stu != null)
            {
                Console.WriteLine(stu.sName);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            List<Student> students1 = students.OrderBy(x => x.avgMarks).ToList();
            foreach(var i in students1)
            {
                Console.WriteLine("Student Name " +i.sName+" Marks: "+i.avgMarks);
            }
            Console.WriteLine(new string('-', 40));
            List<Student> students2 = students.OrderBy(x => x.sName).ThenByDescending(x=>x.age).ToList();
            foreach (var i in students2)
            {
                Console.WriteLine("Student Name " + i.sName + " Age: " + i.age);
            }
        }
    }
}

using EmployeeData;
using EmplyeeDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodefirstapproach
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (EmployeeDBContext db = new EmployeeDBContext())
            {
                //insert new record
                Department department = new Department() { Name = "PAT", Location = "chennai" };
                db.Departments.Add(department);
                db.SaveChanges();
                Employee employee = new Employee() { FirstName = "chandini", LastName = "K", Mobileno = "9876543212", Salary = 20000, Department = department };
                db.Employees.Add(employee);
                db.SaveChanges();
                //fetch record
                Employee employee1 = db.Employees.Find(employee.Id);
                Console.WriteLine("Welcome {0}", employee1.FirstName);
                Console.WriteLine(employee1.Mobileno);
                Console.WriteLine(employee1.Salary);
            }
        }
    }
}


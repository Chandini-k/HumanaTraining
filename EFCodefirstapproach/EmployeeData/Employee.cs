using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeData
{
   public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobileno { get; set; }
        public int Salary { get; set; }
        public Department Department { get; set; }
    }
}

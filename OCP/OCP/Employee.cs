using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee()
        {

        }
        public Employee(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);
        public override string ToString()
        {
            return string.Format("Employee Id: {0} \n Employee Name : {1}", this.Id, this.Name);
        }
    }
}

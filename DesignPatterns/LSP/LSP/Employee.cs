using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public void AssignManager(IEmployee manager)
        {
           
            Manager = manager;
        }
    }
}

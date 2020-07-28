using EmployeeData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmplyeeDb
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Define connection string
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-UJ5GD8G0\SQLEXPRESS;Initial Catalog=EmployeeDB;Persist Security Info=True;User ID=sa;Password=pass@word1");

        }
    }
}

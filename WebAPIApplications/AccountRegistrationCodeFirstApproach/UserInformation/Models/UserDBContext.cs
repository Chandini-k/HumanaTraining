using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserInformation.Models
{
    public class UserDBContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Define connection string
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-UJ5GD8G0\SQLEXPRESS;Initial Catalog=UserDetailsDB;Persist Security Info=True;User ID=sa;Password=pass@word1");

        }
    }
}

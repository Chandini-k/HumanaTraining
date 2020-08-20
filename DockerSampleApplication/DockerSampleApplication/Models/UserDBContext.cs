using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerSampleApplication.Models
{
    public class UserDBContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public UserDBContext (DbContextOptions<UserDBContext> options):base (options)
        {

        }
    }
}

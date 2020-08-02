using AccountRegistration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountRegistration.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly UserDBContext _context;
        public UserRepository(UserDBContext context)
        {
            _context = context;
        }

        public async Task<bool> UserRegister(Users users)
        {
            _context.Users.Add(users);
            var user = await _context.SaveChangesAsync();
            if (user > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Login> UserLogin(Login login)
        {
            Users users = await _context.Users.SingleOrDefaultAsync(e => e.Username == login.username && e.Password == login.password);
            if (users != null)
            {
                return new Login
                {
                    username = users.Username,
                    password = users.Password,
                    userid = users.Userid,
                    occupation=users.Occupation
                };
            }
            else
            {
                Console.WriteLine("Not valid");
                return null;
            }

        }
    }
}

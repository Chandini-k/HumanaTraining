using DockerSampleApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerSampleApplication.Repositories
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
            Users users = await _context.Users.SingleOrDefaultAsync(e => e.username == login.username && e.password == login.password);
            if (users != null)
            {
                return new Login
                {
                    username = users.username,
                    password = users.password,
                    userid = users.userid,
                    occupation = users.occupation
                };
            }
            else
            {
                Console.WriteLine("Not valid");
                return null;
            }

        }
        public async Task<Users> GetProfile(int userid)
        {
            Users users = await _context.Users.FindAsync(userid);
            if (users == null)
                return null;
            else
            {
                return users;
            }
        }

        public async Task<List<Users>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<List<Users>> GetUsersByOccupation(string occupation)
        {
            List<Users> users = await _context.Users.Where(e => e.occupation == occupation).ToListAsync();
            return users;
        }

        public async Task<bool> RemoveProfile(int userid)
        {
            Users users = await _context.Users.FindAsync(userid);
            if (users != null)
            {
                _context.Remove(users);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<bool> UpdateProfile(Users users)
        {
            _context.Users.Update(users);
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
    }
}

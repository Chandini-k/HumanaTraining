using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserInformation.Models;

namespace UserInformation.Repositories
{
    public interface IUserDetailsRepository
    {
        Task<bool> UpdateProfile(Users users);
        Task<Users> GetProfile(int userid);
        Task<List<Users>> GetUsers();
        Task<List<Users>> GetUsersByOccupation(string occupation);
        Task<bool> RemoveProfile(int userid);
    }
}

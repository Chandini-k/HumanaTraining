using DockerSampleApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerSampleApplication.Repositories
{
   public interface IUserRepository
    {
        Task<bool> UserRegister(Users users);
        Task<Login> UserLogin(Login login);
        Task<bool> UpdateProfile(Users users);
        Task<Users> GetProfile(int userid);
        Task<List<Users>> GetUsers();
        Task<List<Users>> GetUsersByOccupation(string occupation);
        Task<bool> RemoveProfile(int userid);
    }
}

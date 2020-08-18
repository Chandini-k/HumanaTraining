using AccountRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountRegister.Repositories
{
    public interface IUserRepository
    {
        Task<bool> UserRegister(Users users);
        Task<Login> UserLogin(Login login);

    }
}

using AccountRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountRegistration.Repositories
{
    public interface IUserRepository
    {
        Task<bool> UserRegister(Users users);
        Task<Login> UserLogin(Login login);

    }
}

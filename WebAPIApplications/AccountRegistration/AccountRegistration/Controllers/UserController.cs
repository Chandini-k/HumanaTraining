using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountRegistration.Models;
using AccountRegistration.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccountRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _iuserRepository;
        public UserController(IUserRepository iuserRepository)
        {
            _iuserRepository = iuserRepository;
        }
        /// <summary>
        /// Register User
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> UserRegister(Users users)
        {
            return Ok(await _iuserRepository.UserRegister(users));

        }
        /// <summary>
        /// Login User
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>login user details</returns>
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> UserLogin(Login login)
        {
            Login login1 = await _iuserRepository.UserLogin(login);
            return Ok(login1);
        }
    }
}

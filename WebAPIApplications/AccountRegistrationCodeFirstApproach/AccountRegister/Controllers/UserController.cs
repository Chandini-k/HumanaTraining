using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AccountRegister.Models;
using AccountRegister.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace AccountRegister.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _iuserRepository;
        private readonly IConfiguration configuration;
        public UserController(IUserRepository iuserRepository,IConfiguration configuration)
        {
            _iuserRepository = iuserRepository;
            this.configuration = configuration;
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
            Token token = null;
            Login login1 = await _iuserRepository.UserLogin(login);
            if (login1 != null)
            {
                token = new Token() { userid = login1.userid, username = login1.username, token = GenerateJwtToken(login1.username), message = "Success" };
            }
            else
            {
                token = new Token() { token = null, message = "UnSuccess" };
            }
            return Ok(token);
        }
        private string GenerateJwtToken(string username)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, username),
                new Claim(ClaimTypes.Role,username)
            };
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            // recommended is 5 min
            var expires = DateTime.Now.AddDays(Convert.ToDouble(configuration["JwtExpireDays"]));
            var token = new JwtSecurityToken(
                configuration["JwtIssuer"],
                configuration["JwtIssuer"],
                claims,
                expires: expires,
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

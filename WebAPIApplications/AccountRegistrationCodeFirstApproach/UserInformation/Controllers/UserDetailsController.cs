using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserInformation.Models;
using UserInformation.Repositories;

namespace UserInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly IUserDetailsRepository _iuserDetailsRepository;
        public UserDetailsController(IUserDetailsRepository iuserDetailsRepository)
        {
            _iuserDetailsRepository = iuserDetailsRepository;
        }
        /// <summary>
        /// Edit User Profile
        /// </summary>
        [HttpPut]
        [Route("EditProfile")]
        public async Task<IActionResult> UpdateProfile(Users users)
        {
            return Ok(await _iuserDetailsRepository.UpdateProfile(users));

        }
        /// <summary>
        /// Get User Profile
        /// </summary>
        /// <param name="userid"></param>
        [HttpGet]
        [Route("Profile/{userid}")]
        public async Task<IActionResult> GetProfile(int userid)
        {
            Users users = await _iuserDetailsRepository.GetProfile(userid);
            if (users == null)
                return Ok("Invalid User");
            else
            {
                return Ok(users);
            }
        }
        /// <summary>
        /// Get All Users
        /// </summary>
        [HttpGet]
        [Route("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            List<Users> users = await _iuserDetailsRepository.GetUsers();
            if (users == null)
                return Ok("Invalid User");
            else
            {
                return Ok(users);
            }
        }
        /// <summary>
        /// Get Users by Occupation
        /// </summary>
        [HttpGet]
        [Route("GetUsers/{occupation}")]
        public async Task<IActionResult> GetUsersByOccupation(string occupation)
        {
            List<Users> users = await _iuserDetailsRepository.GetUsersByOccupation(occupation);
            if (users == null)
                return Ok("Invalid User");
            else
            {
                return Ok(users);
            }
        }
        /// <summary>
        /// Get Users by Occupation
        /// </summary>
        [HttpDelete]
        [Route("Delete/{userid}")]
        public async Task<IActionResult> RemoveUser(int userid)
        {
            return Ok(await _iuserDetailsRepository.RemoveProfile(userid));
        }
    }
}

using System;
using System.Collections.Generic;

namespace AccountRegistration.Models
{
    public partial class Users
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Emailid { get; set; }
        public string Mobileno { get; set; }
        public string Occupation { get; set; }
    }
}

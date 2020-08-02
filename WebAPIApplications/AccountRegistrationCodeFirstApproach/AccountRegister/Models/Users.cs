using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountRegister.Models
{
    public class Users
    {
        [Key]
        public int userid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string emailid { get; set; }
        public string mobileno { get; set; }
        public string occupation { get; set; }
    }
}

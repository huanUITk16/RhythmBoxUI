using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmBox
{
    internal class UserSignInDataClass
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserSignInDataClass(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}

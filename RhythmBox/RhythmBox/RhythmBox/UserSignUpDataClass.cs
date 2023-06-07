using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmBox
{
    internal class UserSignUpDataClass
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public DateTime birthday { get; set; }
        public string gender { get; set; }
        public string avaUrl { get; set; } = "none";

        public UserSignUpDataClass(string username, string password, string email, DateTime birthday, string gender, string imgURL)
        {
            userName = username;
            password = password;
            email = email;
            birthday = birthday;
            gender = gender;
            avaUrl = imgURL;
        }

        public UserSignUpDataClass(string username, string email, string password, DateTime birthday, string gender)
        {
            userName = username;
            email = email;
            password = password;
            birthday = birthday;
            gender = gender;
        }
    }
}

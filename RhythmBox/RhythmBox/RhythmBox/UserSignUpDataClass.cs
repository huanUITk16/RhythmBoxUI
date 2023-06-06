using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmBox
{
    internal class UserSignUpDataClass
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string ImgURL { get; set; } = "none";

        public UserSignUpDataClass(string username, string password, string email, DateTime birthday, string gender, string imgURL)
        {
            Username = username;
            Password = password;
            Email = email;
            Birthday = birthday;
            Gender = gender;
            ImgURL = imgURL;
        }

        public UserSignUpDataClass(string username, string email, string password, DateTime birthday, string gender)
        {
            Username = username;
            Email = email;
            Password = password;
            Birthday = birthday;
            Gender = gender;
        }
    }
}

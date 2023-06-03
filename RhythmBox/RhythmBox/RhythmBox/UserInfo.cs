using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhythmBox
{
    internal class UserInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public GenderType Gender { get; set; }
        public string ImgURL { get; set; } = "none";

        public UserInfo(string username, string password, string email, DateTime birthday, GenderType gender, string imgURL)
        {
            Username = username;
            Password = password;
            Email = email;
            Birthday = birthday;
            Gender = gender;
            ImgURL = imgURL;
        }
    }

    public enum GenderType
    {
        Male,
        Female,
        Other
    }
}

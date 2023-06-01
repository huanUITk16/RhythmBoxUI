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
        public string ImgURL { get; set; }
    }

    public enum GenderType
    {
        Male,
        Female,
        Other
    }
}

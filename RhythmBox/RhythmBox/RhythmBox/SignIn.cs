using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhythmBox
{
    public partial class SignIn : Form
    {
        private string harshPassword(string password)
        {
            SHA256 sha256Hash = SHA256.Create();
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        // Hàm này sẽ được dùng nếu cần thiết
        public bool isEmail(string text)
        {
            if (text.Contains("@"))
                return true;
            return false;
        }

        private string packageSignIn()
        {
            string strUsername = txt_userSI.Text;
            string strPassword = harshPassword(txt_passwordSI.Text);

            UserSignInDataClass newsignin = new UserSignInDataClass(strUsername, strPassword);

            string strResultJson = JsonConvert.SerializeObject(newsignin);

            return strResultJson;
        }

        public SignIn()
        {
            InitializeComponent();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            new MainPage().Show();
            this.Hide();
        }

        private void link_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void checkbox_show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_show.Checked)
            {
                txt_passwordSI.PasswordChar = '\0';
                
            }
            else
            {
                txt_passwordSI.PasswordChar = '*';
                
            }
        }
    }
}

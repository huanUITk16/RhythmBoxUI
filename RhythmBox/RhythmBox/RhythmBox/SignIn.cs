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
        ApiService apiService = new ApiService();
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

        private async void btn_signin_Click(object sender, EventArgs e)
        {
            bool signinRes = await apiService.SignIn(txt_userSI.Text, harshPassword(txt_passwordSI.Text));

            if (signinRes)
            {
                new MainPage().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password incorrect!!", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_userSI.Clear();
                txt_passwordSI.Clear();
                txt_userSI.Focus();
                return;
            }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new forgotPassword().Show();
            this.Hide();
        }
    }
}

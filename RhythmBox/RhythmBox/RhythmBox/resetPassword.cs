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
    public partial class resetPassword : Form
    {
        ApiService apiService= new ApiService();
        private string hashPassword(string password)
        {
            SHA256 sha256Hash = SHA256.Create();
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        public resetPassword()
        {
            InitializeComponent();
        }

        private async void btn_resetPassword_Click(object sender, EventArgs e)
        {
            string email = forgotPassword.enteredEmail;

            if (txt_newPassword.Text != txt_confirmnewpassword.Text)
            {
                txt_newPassword.Clear();
                txt_confirmnewpassword.Clear();
                MessageBox.Show("Error");
                return;
            }
            else
            {
                bool renewRes = await apiService.RenewPassword(email, hashPassword(txt_newPassword.Text));
                if (renewRes)
                {
                    MessageBox.Show("Reset password successfully");
                    SignIn signIn = new SignIn();
                    signIn.Show();
                    this.Hide();
                }
            }
        }
    }
}

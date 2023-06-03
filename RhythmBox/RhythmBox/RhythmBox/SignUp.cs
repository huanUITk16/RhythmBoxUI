using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System;

namespace RhythmBox
{
    public partial class SignUp : Form
    {
        private string hashPassword(string password)
        {
            SHA256 sha256Hash = SHA256.Create();
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        public bool isValidPass(string password1, string password2)
        {
            if (password1.Length < 3)
                return false;
            else if (password1 != password2)
                return false;
            return true;
        }

        public int IntMonth(string sMonth)
        {
            switch (sMonth)
            {
                case "January":
                    return 1;
                    break;
                case "February":
                    return 2;
                    break;
                case "March":
                    return 3;
                    break;
                case "April":
                    return 4;
                    break;
                case "May":
                    return 5;
                    break;
                case "June":
                    return 6;
                    break;
                case "July":
                    return 7;
                    break;
                case "August":
                    return 8;
                    break;
                case "September":
                    return 9;
                    break;
                case "October":
                    return 10;
                    break;
                case "November":
                    return 11;
                    break;
                case "December":
                    return 12;
                    break;
                default:
                    return 0;
            }
        }

        private string packageSignUp()
        {
            string sUsername = txt_userSU.Text;
            string sTypePassword = hashPassword(txt_passwordSU.Text);
            string sEmail = txt_email.Text;
            int iYear = int.Parse(txt_year.Text);
            int iMonth = IntMonth(cbBox_month.Text);
            int iDate = int.Parse(txt_day.Text);
            DateTime dBirthday = new DateTime(iYear, iMonth, iDate);

            //UserInfo newuser = new UserInfo(sUsername, sTypePassword, dBirthday, );

            return "";
        }

        public SignUp()
        {
            InitializeComponent();
            
        }

        private void btn_signup_Click(object sender, System.EventArgs e)
        {
            if (txt_userSU.Text == "" && txt_passwordSU.Text == "" && txt_confirmSU.Text == "")
            {
                MessageBox.Show("Username and Password box are empty", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_userSU.Focus();

            }
            else if (txt_passwordSU.Text == txt_confirmSU.Text)
            {
                /* conn.Open();
                string register = "INSERT INTO user_password VALUES ('" + txt_userSU.Text + " " + txt_passwordSU.Text + "')"; // send new username and password to database
                cmd = new OleDbCommand(register,conn);
                cmd.ExecuteNonQuery();
                conn.Close(); */


                MessageBox.Show("Your account has been created","let's sign in",MessageBoxButtons.OK, MessageBoxIcon.Information); // create account successfully
            }
            else 
            {
                MessageBox.Show("Password does not match", "please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_passwordSU.Text = "";
                txt_confirmSU.Text = "";
                txt_userSU.Focus();
            }
        }

        private void checkbox_show_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkbox_show.Checked)
            {
                txt_passwordSU.PasswordChar = '\0';
                txt_confirmSU.PasswordChar= '\0';
            }
            else
            {
                txt_passwordSU.PasswordChar = '*';
                txt_confirmSU.PasswordChar = '*';
            }
        }

        private void link_signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void SignUp_Load(object sender, System.EventArgs e)
        {

        }

        private void cbBox_month_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}

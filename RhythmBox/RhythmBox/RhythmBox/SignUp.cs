using System.Windows.Forms;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using System;

namespace RhythmBox
{
    public partial class SignUp : Form
    {
        ApiService apiService = new ApiService();
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
                case "February":
                    return 2;
                case "March":
                    return 3;
                case "April":
                    return 4;
                case "May":
                    return 5;
                case "June":
                    return 6;
                case "July":
                    return 7;
                case "August":
                    return 8;
                case "September":
                    return 9;
                case "October":
                    return 10;
                case "November":
                    return 11;
                case "December":
                    return 12;
                default:
                    return 0;
            }
        }

        public string checkboxtostringGender()
        {
            if (checkBox_male.Checked)
                return "Male";
            else if (checkBox_female.Checked)
                return "Female";
            else if (checkBox_no.Checked)
                return "Other";
            return "Error Gender!!";
        }

        private string packageSignUp()
        {
            string strUsername = txt_userSU.Text;
            string strTypePassword = hashPassword(txt_passwordSU.Text);
            string strEmail = txt_email.Text;
            string strGender = checkboxtostringGender();
            int iYear = int.Parse(txt_year.Text);
            int iMonth = IntMonth(cbBox_month.Text);
            int iDate = int.Parse(txt_day.Text);
            DateTime dBirthday = new DateTime(iYear, iMonth, iDate);

            UserSignUpDataClass newuser = new UserSignUpDataClass(strUsername, strTypePassword, strEmail, dBirthday, strGender);

            string strResultJson = JsonConvert.SerializeObject(newuser);

            return strResultJson;
        }

        public SignUp()
        {
            InitializeComponent();
            
        }

        private async void btn_signup_Click(object sender, System.EventArgs e)
        {
            int iYear = int.Parse(txt_year.Text);
            int iMonth = IntMonth(cbBox_month.Text);
            int iDate = int.Parse(txt_day.Text);
            DateTime dBirthday = new DateTime(iYear, iMonth, iDate);

            bool signupRes = await apiService.SignUp(txt_userSU.Text, txt_email.Text, hashPassword(txt_passwordSU.Text), dBirthday, checkboxtostringGender());

            if (txt_userSU.Text == "" && txt_passwordSU.Text == "" && txt_confirmSU.Text == "")
            {
                MessageBox.Show("Username and Password box are empty", "Try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_userSU.Focus();

            }
            else if (txt_passwordSU.Text == txt_confirmSU.Text && signupRes)
            {
                MessageBox.Show("Your account has been created","let's sign in",MessageBoxButtons.OK, MessageBoxIcon.Information); // create account successfully

                SignIn signIn = new SignIn();
                signIn.Show();
                this.Hide();
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

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox_male.Checked)
            {
                checkBox_female.Enabled = false;
                checkBox_no.Enabled = false;
            }
            else
            {
                checkBox_female.Enabled = true;
                checkBox_no.Enabled = true;
            }
            
        }

        private void checkBox_female_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox_female.Checked)
            {
                checkBox_male.Enabled = false;
                checkBox_no.Enabled = false;
            }
            else
            {
                checkBox_male.Enabled = true;
                checkBox_no.Enabled = true;
            }
        }

        private void checkBox_no_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox_no.Checked)
            {
                checkBox_male.Enabled = false;
                checkBox_female.Enabled = false;
            }
            else
            {
                checkBox_male.Enabled = true;
                checkBox_female.Enabled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new signupGoogle().Show();
            this.Hide();
        }
    }
}

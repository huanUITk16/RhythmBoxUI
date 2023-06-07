using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhythmBox
{
    public partial class enterCodeResetPassword : Form
    {
        ApiService apiService = new ApiService();
        string email = forgotPassword.enteredEmail;
        public enterCodeResetPassword()
        {
            InitializeComponent();
        }

        private async void btn_send_Click(object sender, EventArgs e)
        {
            int otp = int.Parse(txt_codeReset.Text);
            bool authRes = await apiService.AuthOTP(email, otp);

            if (authRes)
            {
                new resetPassword().Show();
                this.Hide();
            }
            else
                MessageBox.Show("Error");
        }
    }
}

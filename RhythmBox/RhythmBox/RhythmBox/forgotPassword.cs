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
    public partial class forgotPassword : Form
    {
        ApiService apiService = new ApiService();
        public static string enteredEmail {  get; set; }
        public forgotPassword()
        {
            InitializeComponent();
        }

        private async void btn_send_Click(object sender, EventArgs e)
        {
            bool resetRes = await apiService.ForgotPassword(txt_emailReset.Text);
            enteredEmail = txt_emailReset.Text;
            if (resetRes)
            {
                new enterCodeResetPassword().Show();
                this.Hide();
            }
            else
                MessageBox.Show("Error");
        }
    }
}

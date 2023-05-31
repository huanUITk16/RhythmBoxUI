namespace RhythmBox
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_userSU = new System.Windows.Forms.TextBox();
            this.txt_passwordSU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_confirmSU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkbox_show = new System.Windows.Forms.CheckBox();
            this.btn_signup = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.link_signin = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // txt_userSU
            // 
            this.txt_userSU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_userSU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userSU.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userSU.Location = new System.Drawing.Point(30, 130);
            this.txt_userSU.Multiline = true;
            this.txt_userSU.Name = "txt_userSU";
            this.txt_userSU.Size = new System.Drawing.Size(303, 29);
            this.txt_userSU.TabIndex = 3;
            // 
            // txt_passwordSU
            // 
            this.txt_passwordSU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_passwordSU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_passwordSU.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwordSU.Location = new System.Drawing.Point(30, 199);
            this.txt_passwordSU.Multiline = true;
            this.txt_passwordSU.Name = "txt_passwordSU";
            this.txt_passwordSU.PasswordChar = '*';
            this.txt_passwordSU.Size = new System.Drawing.Size(303, 29);
            this.txt_passwordSU.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(26, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // txt_confirmSU
            // 
            this.txt_confirmSU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_confirmSU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirmSU.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmSU.Location = new System.Drawing.Point(30, 269);
            this.txt_confirmSU.Multiline = true;
            this.txt_confirmSU.Name = "txt_confirmSU";
            this.txt_confirmSU.PasswordChar = '*';
            this.txt_confirmSU.Size = new System.Drawing.Size(303, 29);
            this.txt_confirmSU.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(26, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password:";
            // 
            // checkbox_show
            // 
            this.checkbox_show.AutoSize = true;
            this.checkbox_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbox_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbox_show.Location = new System.Drawing.Point(203, 304);
            this.checkbox_show.Name = "checkbox_show";
            this.checkbox_show.Size = new System.Drawing.Size(160, 24);
            this.checkbox_show.TabIndex = 8;
            this.checkbox_show.Text = "Show Password";
            this.checkbox_show.UseVisualStyleBackColor = true;
            this.checkbox_show.CheckedChanged += new System.EventHandler(this.checkbox_show_CheckedChanged);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.FlatAppearance.BorderSize = 0;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_signup.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_signup.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_signup.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_signup.IconSize = 30;
            this.btn_signup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signup.Location = new System.Drawing.Point(86, 350);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.btn_signup.Size = new System.Drawing.Size(200, 44);
            this.btn_signup.TabIndex = 9;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_signup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(48, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Have an Account?";
            // 
            // link_signin
            // 
            this.link_signin.ActiveLinkColor = System.Drawing.Color.White;
            this.link_signin.AutoSize = true;
            this.link_signin.LinkColor = System.Drawing.Color.White;
            this.link_signin.Location = new System.Drawing.Point(219, 413);
            this.link_signin.Name = "link_signin";
            this.link_signin.Size = new System.Drawing.Size(67, 20);
            this.link_signin.TabIndex = 11;
            this.link_signin.TabStop = true;
            this.link_signin.Text = "Sign In";
            this.link_signin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_signin_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.LinkColor = System.Drawing.Color.Firebrick;
            this.linkLabel1.Location = new System.Drawing.Point(82, 450);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(217, 20);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Or Sign Up With Google ";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(373, 544);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.link_signin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.checkbox_show);
            this.Controls.Add(this.txt_confirmSU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_passwordSU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_userSU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_userSU;
        private System.Windows.Forms.TextBox txt_passwordSU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_confirmSU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkbox_show;
        private FontAwesome.Sharp.IconButton btn_signup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel link_signin;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
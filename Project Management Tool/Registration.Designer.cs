using System;
using System.Windows.Forms;

namespace Project_Management_Tool
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.registrationPage = new System.Windows.Forms.Panel();
            this.reg = new System.Windows.Forms.Panel();
            this.regRegister = new System.Windows.Forms.Label();
            this.regUserAvatar = new System.Windows.Forms.Label();
            this.regProfile = new System.Windows.Forms.PictureBox();
            this.regOrg = new System.Windows.Forms.Label();
            this.txtOrg = new System.Windows.Forms.TextBox();
            this.regOrgID = new System.Windows.Forms.Label();
            this.txtOrgID = new System.Windows.Forms.TextBox();
            this.regLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.regPhno = new System.Windows.Forms.Label();
            this.regFName = new System.Windows.Forms.Label();
            this.txtPhno = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.regConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.regUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.regLoginRedirect = new System.Windows.Forms.Label();
            this.regPassword = new System.Windows.Forms.Label();
            this.regEmailID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btbregister = new System.Windows.Forms.Button();
            this.regClose = new System.Windows.Forms.PictureBox();
            this.registrationPage.SuspendLayout();
            this.reg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regClose)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationPage
            // 
            this.registrationPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.registrationPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationPage.Controls.Add(this.reg);
            this.registrationPage.Controls.Add(this.regUserAvatar);
            this.registrationPage.Controls.Add(this.regProfile);
            this.registrationPage.Controls.Add(this.regOrg);
            this.registrationPage.Controls.Add(this.txtOrg);
            this.registrationPage.Controls.Add(this.regOrgID);
            this.registrationPage.Controls.Add(this.txtOrgID);
            this.registrationPage.Controls.Add(this.regLName);
            this.registrationPage.Controls.Add(this.txtLName);
            this.registrationPage.Controls.Add(this.regPhno);
            this.registrationPage.Controls.Add(this.regFName);
            this.registrationPage.Controls.Add(this.txtPhno);
            this.registrationPage.Controls.Add(this.txtFName);
            this.registrationPage.Controls.Add(this.regConfirmPassword);
            this.registrationPage.Controls.Add(this.txtConfirmPass);
            this.registrationPage.Controls.Add(this.regUsername);
            this.registrationPage.Controls.Add(this.txtUsername);
            this.registrationPage.Controls.Add(this.regLoginRedirect);
            this.registrationPage.Controls.Add(this.regPassword);
            this.registrationPage.Controls.Add(this.regEmailID);
            this.registrationPage.Controls.Add(this.txtPassword);
            this.registrationPage.Controls.Add(this.txtEmail);
            this.registrationPage.Controls.Add(this.btbregister);
            this.registrationPage.Location = new System.Drawing.Point(63, 34);
            this.registrationPage.Margin = new System.Windows.Forms.Padding(2);
            this.registrationPage.Name = "registrationPage";
            this.registrationPage.Size = new System.Drawing.Size(828, 440);
            this.registrationPage.TabIndex = 29;
            // 
            // reg
            // 
            this.reg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg.Controls.Add(this.regRegister);
            this.reg.Location = new System.Drawing.Point(173, -1);
            this.reg.Margin = new System.Windows.Forms.Padding(2);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(486, 34);
            this.reg.TabIndex = 12;
            // 
            // regRegister
            // 
            this.regRegister.AutoSize = true;
            this.regRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regRegister.Location = new System.Drawing.Point(219, 5);
            this.regRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regRegister.Name = "regRegister";
            this.regRegister.Size = new System.Drawing.Size(67, 21);
            this.regRegister.TabIndex = 7;
            this.regRegister.Text = "Register";
            // 
            // regUserAvatar
            // 
            this.regUserAvatar.AutoSize = true;
            this.regUserAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUserAvatar.Location = new System.Drawing.Point(555, 126);
            this.regUserAvatar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regUserAvatar.Name = "regUserAvatar";
            this.regUserAvatar.Size = new System.Drawing.Size(93, 20);
            this.regUserAvatar.TabIndex = 26;
            this.regUserAvatar.Text = "User Avatar";
            // 
            // regProfile
            // 
            this.regProfile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.regProfile.Location = new System.Drawing.Point(568, 57);
            this.regProfile.Margin = new System.Windows.Forms.Padding(2);
            this.regProfile.Name = "regProfile";
            this.regProfile.Size = new System.Drawing.Size(69, 67);
            this.regProfile.TabIndex = 25;
            this.regProfile.TabStop = false;
            // 
            // regOrg
            // 
            this.regOrg.AutoSize = true;
            this.regOrg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regOrg.Location = new System.Drawing.Point(49, 262);
            this.regOrg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regOrg.Name = "regOrg";
            this.regOrg.Size = new System.Drawing.Size(103, 21);
            this.regOrg.TabIndex = 24;
            this.regOrg.Text = "Organization:";
            // 
            // txtOrg
            // 
            this.txtOrg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrg.Location = new System.Drawing.Point(199, 264);
            this.txtOrg.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrg.Name = "txtOrg";
            this.txtOrg.Size = new System.Drawing.Size(166, 22);
            this.txtOrg.TabIndex = 23;
            // 
            // regOrgID
            // 
            this.regOrgID.AutoSize = true;
            this.regOrgID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regOrgID.Location = new System.Drawing.Point(49, 306);
            this.regOrgID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regOrgID.Name = "regOrgID";
            this.regOrgID.Size = new System.Drawing.Size(122, 21);
            this.regOrgID.TabIndex = 22;
            this.regOrgID.Text = "Organization ID:";
            // 
            // txtOrgID
            // 
            this.txtOrgID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgID.Location = new System.Drawing.Point(199, 306);
            this.txtOrgID.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrgID.Name = "txtOrgID";
            this.txtOrgID.Size = new System.Drawing.Size(166, 22);
            this.txtOrgID.TabIndex = 21;
            // 
            // regLName
            // 
            this.regLName.AutoSize = true;
            this.regLName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLName.Location = new System.Drawing.Point(428, 234);
            this.regLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regLName.Name = "regLName";
            this.regLName.Size = new System.Drawing.Size(87, 21);
            this.regLName.TabIndex = 20;
            this.regLName.Text = "Last Name:";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(568, 234);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(148, 22);
            this.txtLName.TabIndex = 19;
            // 
            // regPhno
            // 
            this.regPhno.AutoSize = true;
            this.regPhno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPhno.Location = new System.Drawing.Point(428, 282);
            this.regPhno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regPhno.Name = "regPhno";
            this.regPhno.Size = new System.Drawing.Size(119, 21);
            this.regPhno.TabIndex = 18;
            this.regPhno.Text = "Phone Number:";
            // 
            // regFName
            // 
            this.regFName.AutoSize = true;
            this.regFName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regFName.Location = new System.Drawing.Point(428, 188);
            this.regFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regFName.Name = "regFName";
            this.regFName.Size = new System.Drawing.Size(93, 21);
            this.regFName.TabIndex = 17;
            this.regFName.Text = "First Name :";
            // 
            // txtPhno
            // 
            this.txtPhno.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhno.Location = new System.Drawing.Point(568, 284);
            this.txtPhno.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhno.Name = "txtPhno";
            this.txtPhno.Size = new System.Drawing.Size(148, 22);
            this.txtPhno.TabIndex = 16;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(568, 188);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(148, 22);
            this.txtFName.TabIndex = 15;
            // 
            // regConfirmPassword
            // 
            this.regConfirmPassword.AutoSize = true;
            this.regConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regConfirmPassword.Location = new System.Drawing.Point(49, 219);
            this.regConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regConfirmPassword.Name = "regConfirmPassword";
            this.regConfirmPassword.Size = new System.Drawing.Size(140, 21);
            this.regConfirmPassword.TabIndex = 14;
            this.regConfirmPassword.Text = "Confirm Password:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(199, 221);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(166, 22);
            this.txtConfirmPass.TabIndex = 13;
            // 
            // regUsername
            // 
            this.regUsername.AutoSize = true;
            this.regUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUsername.Location = new System.Drawing.Point(49, 136);
            this.regUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(84, 21);
            this.regUsername.TabIndex = 10;
            this.regUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(199, 138);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(166, 22);
            this.txtUsername.TabIndex = 9;
            // 
            // regLoginRedirect
            // 
            this.regLoginRedirect.AutoSize = true;
            this.regLoginRedirect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLoginRedirect.Location = new System.Drawing.Point(333, 393);
            this.regLoginRedirect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regLoginRedirect.Name = "regLoginRedirect";
            this.regLoginRedirect.Size = new System.Drawing.Size(194, 21);
            this.regLoginRedirect.TabIndex = 8;
            this.regLoginRedirect.Text = "Already Registered? Login.";
            this.regLoginRedirect.Click += new System.EventHandler(this.regLoginRedirect_Click);
            // 
            // regPassword
            // 
            this.regPassword.AutoSize = true;
            this.regPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPassword.Location = new System.Drawing.Point(49, 180);
            this.regPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(83, 21);
            this.regPassword.TabIndex = 7;
            this.regPassword.Text = "Password :";
            // 
            // regEmailID
            // 
            this.regEmailID.AutoSize = true;
            this.regEmailID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regEmailID.Location = new System.Drawing.Point(49, 91);
            this.regEmailID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.regEmailID.Name = "regEmailID";
            this.regEmailID.Size = new System.Drawing.Size(74, 21);
            this.regEmailID.TabIndex = 6;
            this.regEmailID.Text = "Email ID :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(199, 180);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(199, 93);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // btbregister
            // 
            this.btbregister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbregister.Location = new System.Drawing.Point(377, 352);
            this.btbregister.Margin = new System.Windows.Forms.Padding(2);
            this.btbregister.Name = "btbregister";
            this.btbregister.Size = new System.Drawing.Size(95, 30);
            this.btbregister.TabIndex = 0;
            this.btbregister.Text = "Register";
            this.btbregister.UseVisualStyleBackColor = true;
            this.btbregister.Click += new System.EventHandler(this.btbregister_Click);
            // 
            // regClose
            // 
            this.regClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.regClose.Image = ((System.Drawing.Image)(resources.GetObject("regClose.Image")));
            this.regClose.Location = new System.Drawing.Point(934, 11);
            this.regClose.Margin = new System.Windows.Forms.Padding(2);
            this.regClose.Name = "regClose";
            this.regClose.Size = new System.Drawing.Size(30, 25);
            this.regClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regClose.TabIndex = 30;
            this.regClose.TabStop = false;
            this.regClose.Click += new System.EventHandler(this.regClose_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(975, 585);
            this.Controls.Add(this.regClose);
            this.Controls.Add(this.registrationPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registration";
            this.Text = "Form2";
            this.registrationPage.ResumeLayout(false);
            this.registrationPage.PerformLayout();
            this.reg.ResumeLayout(false);
            this.reg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel registrationPage;
        private Panel reg;
        private Label regRegister;
        private Label regUserAvatar;
        private PictureBox regProfile;
        private Label regOrg;
        private TextBox txtOrg;
        private Label regOrgID;
        private TextBox txtOrgID;
        private Label regLName;
        private TextBox txtLName;
        private Label regPhno;
        private Label regFName;
        private TextBox txtPhno;
        private TextBox txtFName;
        private Label regConfirmPassword;
        private TextBox txtConfirmPass;
        private Label regUsername;
        private TextBox txtUsername;
        private Label regLoginRedirect;
        private Label regPassword;
        private Label regEmailID;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btbregister;
        private PictureBox regClose;

        public EventHandler Form2_Load { get; private set; }
    }
}
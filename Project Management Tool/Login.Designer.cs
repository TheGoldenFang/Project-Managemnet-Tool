using System;

namespace Project_Management_Tool
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginClose = new System.Windows.Forms.PictureBox();
            this.basicdiagramspannel = new System.Windows.Forms.Panel();
            this.btblogin = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.loginPassword = new System.Windows.Forms.Label();
            this.loginUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.welcomepannel = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginClose)).BeginInit();
            this.basicdiagramspannel.SuspendLayout();
            this.welcomepannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginClose
            // 
            this.loginClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loginClose.Image = ((System.Drawing.Image)(resources.GetObject("loginClose.Image")));
            this.loginClose.Location = new System.Drawing.Point(878, 10);
            this.loginClose.Margin = new System.Windows.Forms.Padding(2);
            this.loginClose.Name = "loginClose";
            this.loginClose.Size = new System.Drawing.Size(30, 25);
            this.loginClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginClose.TabIndex = 28;
            this.loginClose.TabStop = false;
            this.loginClose.Click += new System.EventHandler(this.loginClose_Click);
            // 
            // basicdiagramspannel
            // 
            this.basicdiagramspannel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.basicdiagramspannel.Controls.Add(this.btblogin);
            this.basicdiagramspannel.Controls.Add(this.lblRegister);
            this.basicdiagramspannel.Controls.Add(this.loginPassword);
            this.basicdiagramspannel.Controls.Add(this.loginUsername);
            this.basicdiagramspannel.Controls.Add(this.txtPassword);
            this.basicdiagramspannel.Controls.Add(this.txtUsername);
            this.basicdiagramspannel.Location = new System.Drawing.Point(286, 96);
            this.basicdiagramspannel.Margin = new System.Windows.Forms.Padding(2);
            this.basicdiagramspannel.Name = "basicdiagramspannel";
            this.basicdiagramspannel.Size = new System.Drawing.Size(357, 365);
            this.basicdiagramspannel.TabIndex = 34;
            // 
            // btblogin
            // 
            this.btblogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btblogin.Location = new System.Drawing.Point(86, 251);
            this.btblogin.Margin = new System.Windows.Forms.Padding(2);
            this.btblogin.Name = "btblogin";
            this.btblogin.Size = new System.Drawing.Size(172, 32);
            this.btblogin.TabIndex = 34;
            this.btblogin.Text = "Login";
            this.btblogin.UseVisualStyleBackColor = false;
            this.btblogin.Click += new System.EventHandler(this.btblogin_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(108, 294);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(127, 19);
            this.lblRegister.TabIndex = 39;
            this.lblRegister.Text = "New User? Register";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // loginPassword
            // 
            this.loginPassword.AutoSize = true;
            this.loginPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loginPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassword.Location = new System.Drawing.Point(49, 186);
            this.loginPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(83, 21);
            this.loginPassword.TabIndex = 38;
            this.loginPassword.Text = "Password :";
            // 
            // loginUsername
            // 
            this.loginUsername.AutoSize = true;
            this.loginUsername.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loginUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsername.Location = new System.Drawing.Point(46, 139);
            this.loginUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(88, 21);
            this.loginUsername.TabIndex = 37;
            this.loginUsername.Text = "Username :";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(154, 188);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(158, 22);
            this.txtPassword.TabIndex = 36;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(154, 139);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(158, 22);
            this.txtUsername.TabIndex = 35;
            // 
            // welcomepannel
            // 
            this.welcomepannel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.welcomepannel.Controls.Add(this.lblWelcome);
            this.welcomepannel.Location = new System.Drawing.Point(286, 96);
            this.welcomepannel.Margin = new System.Windows.Forms.Padding(2);
            this.welcomepannel.Name = "welcomepannel";
            this.welcomepannel.Size = new System.Drawing.Size(355, 44);
            this.welcomepannel.TabIndex = 40;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(133, 12);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(79, 21);
            this.lblWelcome.TabIndex = 38;
            this.lblWelcome.Text = "Welcome!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(917, 553);
            this.Controls.Add(this.welcomepannel);
            this.Controls.Add(this.basicdiagramspannel);
            this.Controls.Add(this.loginClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.loginClose)).EndInit();
            this.basicdiagramspannel.ResumeLayout(false);
            this.basicdiagramspannel.PerformLayout();
            this.welcomepannel.ResumeLayout(false);
            this.welcomepannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox loginClose;
        private System.Windows.Forms.Panel basicdiagramspannel;
        private System.Windows.Forms.Button btblogin;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label loginPassword;
        private System.Windows.Forms.Label loginUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel welcomepannel;
        private System.Windows.Forms.Label lblWelcome;
    }
}


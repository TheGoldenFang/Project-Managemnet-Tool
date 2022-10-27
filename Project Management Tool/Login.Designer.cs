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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.lblloginoption = new System.Windows.Forms.Label();
            this.btblogin = new System.Windows.Forms.Button();
            this.loginUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.welcomepanel = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginClose)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.welcomepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginClose
            // 
            this.loginClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginClose.Image = ((System.Drawing.Image)(resources.GetObject("loginClose.Image")));
            this.loginClose.Location = new System.Drawing.Point(893, 13);
            this.loginClose.Margin = new System.Windows.Forms.Padding(2);
            this.loginClose.Name = "loginClose";
            this.loginClose.Size = new System.Drawing.Size(16, 15);
            this.loginClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginClose.TabIndex = 28;
            this.loginClose.TabStop = false;
            this.loginClose.Click += new System.EventHandler(this.loginClose_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.Controls.Add(this.lblloginoption);
            this.LoginPanel.Controls.Add(this.btblogin);
            this.LoginPanel.Controls.Add(this.loginUsername);
            this.LoginPanel.Controls.Add(this.txtUsername);
            this.LoginPanel.Controls.Add(this.loginPassword);
            this.LoginPanel.Controls.Add(this.txtPassword);
            this.LoginPanel.Location = new System.Drawing.Point(286, 96);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(353, 323);
            this.LoginPanel.TabIndex = 34;
            // 
            // lblloginoption
            // 
            this.lblloginoption.AutoSize = true;
            this.lblloginoption.BackColor = System.Drawing.Color.Transparent;
            this.lblloginoption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginoption.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblloginoption.Location = new System.Drawing.Point(17, 91);
            this.lblloginoption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblloginoption.Name = "lblloginoption";
            this.lblloginoption.Size = new System.Drawing.Size(148, 19);
            this.lblloginoption.TabIndex = 40;
            this.lblloginoption.Text = "Log in to your account";
            // 
            // btblogin
            // 
            this.btblogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btblogin.Location = new System.Drawing.Point(91, 259);
            this.btblogin.Margin = new System.Windows.Forms.Padding(2);
            this.btblogin.Name = "btblogin";
            this.btblogin.Size = new System.Drawing.Size(172, 32);
            this.btblogin.TabIndex = 34;
            this.btblogin.Text = "Login";
            this.btblogin.UseVisualStyleBackColor = false;
            this.btblogin.Click += new System.EventHandler(this.btblogin_Click);
            // 
            // loginUsername
            // 
            this.loginUsername.AutoSize = true;
            this.loginUsername.BackColor = System.Drawing.Color.Transparent;
            this.loginUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginUsername.Location = new System.Drawing.Point(17, 123);
            this.loginUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(85, 21);
            this.loginUsername.TabIndex = 37;
            this.loginUsername.Text = "Username ";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(21, 150);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(290, 22);
            this.txtUsername.TabIndex = 35;
            // 
            // loginPassword
            // 
            this.loginPassword.AutoSize = true;
            this.loginPassword.BackColor = System.Drawing.Color.Transparent;
            this.loginPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginPassword.Location = new System.Drawing.Point(19, 182);
            this.loginPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(80, 21);
            this.loginPassword.TabIndex = 38;
            this.loginPassword.Text = "Password ";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(21, 213);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(290, 22);
            this.txtPassword.TabIndex = 36;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegister.Location = new System.Drawing.Point(400, 431);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(127, 19);
            this.lblRegister.TabIndex = 39;
            this.lblRegister.Text = "New User? Register";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // welcomepanel
            // 
            this.welcomepanel.BackColor = System.Drawing.Color.Transparent;
            this.welcomepanel.Controls.Add(this.lblWelcome);
            this.welcomepanel.Location = new System.Drawing.Point(286, 96);
            this.welcomepanel.Margin = new System.Windows.Forms.Padding(2);
            this.welcomepanel.Name = "welcomepanel";
            this.welcomepanel.Size = new System.Drawing.Size(353, 44);
            this.welcomepanel.TabIndex = 40;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(130, 10);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(95, 25);
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
            this.Controls.Add(this.welcomepanel);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.loginClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginClose)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.welcomepanel.ResumeLayout(false);
            this.welcomepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox loginClose;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button btblogin;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label loginPassword;
        private System.Windows.Forms.Label loginUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel welcomepanel;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblloginoption;
    }
}


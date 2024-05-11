
namespace NadraManagementGUI
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdClose = new System.Windows.Forms.Button();
            this.lblLoginScreen = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmdSignIn = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            this.lnkSignUp = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblLoginScreen);
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 67);
            this.panel1.TabIndex = 0;
            // 
            // cmdClose
            // 
            this.cmdClose.BackColor = System.Drawing.Color.Teal;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdClose.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdClose.Location = new System.Drawing.Point(788, 10);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(45, 41);
            this.cmdClose.TabIndex = 1;
            this.cmdClose.Text = "X";
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // lblLoginScreen
            // 
            this.lblLoginScreen.AutoSize = true;
            this.lblLoginScreen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginScreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLoginScreen.Location = new System.Drawing.Point(51, 23);
            this.lblLoginScreen.Name = "lblLoginScreen";
            this.lblLoginScreen.Size = new System.Drawing.Size(133, 22);
            this.lblLoginScreen.TabIndex = 2;
            this.lblLoginScreen.Text = "LOGIN  PAGE";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(43, 14);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(187, 19);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "Username";
            this.txtUserName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUserName_MouseClick);
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(43, 15);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 19);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Location = new System.Drawing.Point(327, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 48);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Location = new System.Drawing.Point(327, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 46);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // cmdSignIn
            // 
            this.cmdSignIn.BackColor = System.Drawing.Color.Teal;
            this.cmdSignIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSignIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSignIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdSignIn.Image = ((System.Drawing.Image)(resources.GetObject("cmdSignIn.Image")));
            this.cmdSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSignIn.Location = new System.Drawing.Point(337, 375);
            this.cmdSignIn.Name = "cmdSignIn";
            this.cmdSignIn.Size = new System.Drawing.Size(106, 37);
            this.cmdSignIn.TabIndex = 5;
            this.cmdSignIn.Text = "Sign In";
            this.cmdSignIn.UseVisualStyleBackColor = false;
            this.cmdSignIn.Click += new System.EventHandler(this.cmdSignIn_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.BackColor = System.Drawing.Color.Teal;
            this.cmdReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdReset.Image = ((System.Drawing.Image)(resources.GetObject("cmdReset.Image")));
            this.cmdReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdReset.Location = new System.Drawing.Point(449, 375);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(108, 37);
            this.cmdReset.TabIndex = 6;
            this.cmdReset.Text = "Clear";
            this.cmdReset.UseVisualStyleBackColor = false;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // lnkSignUp
            // 
            this.lnkSignUp.AutoSize = true;
            this.lnkSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lnkSignUp.DisabledLinkColor = System.Drawing.Color.Blue;
            this.lnkSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSignUp.ForeColor = System.Drawing.Color.Blue;
            this.lnkSignUp.LinkColor = System.Drawing.Color.Yellow;
            this.lnkSignUp.Location = new System.Drawing.Point(405, 322);
            this.lnkSignUp.Name = "lnkSignUp";
            this.lnkSignUp.Size = new System.Drawing.Size(70, 20);
            this.lnkSignUp.TabIndex = 9;
            this.lnkSignUp.TabStop = true;
            this.lnkSignUp.Text = "Sign up";
            this.lnkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSignUp_LinkClicked);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(845, 461);
            this.ControlBox = false;
            this.Controls.Add(this.lnkSignUp);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdSignIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginScreen";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoginScreen;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cmdSignIn;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.LinkLabel lnkSignUp;
    }
}
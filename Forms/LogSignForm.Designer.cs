using System.Windows.Forms;

namespace Password_Manager
{
    partial class LogSignForm
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panelLogSign = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panelChooseOption = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtChangePassword = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSeePasswords = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogSign.SuspendLayout();
            this.panelChooseOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(242, 147);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(304, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(242, 254);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(304, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TabStop = false;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.Location = new System.Drawing.Point(296, 113);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(194, 31);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogSign
            // 
            this.panelLogSign.BackColor = System.Drawing.Color.GhostWhite;
            this.panelLogSign.Controls.Add(this.btnSignUp);
            this.panelLogSign.Controls.Add(this.btnLogIn);
            this.panelLogSign.Controls.Add(this.label3);
            this.panelLogSign.Controls.Add(this.lblPassword);
            this.panelLogSign.Controls.Add(this.lblUsername);
            this.panelLogSign.Controls.Add(this.txtPassword);
            this.panelLogSign.Controls.Add(this.txtUsername);
            this.panelLogSign.Location = new System.Drawing.Point(12, 12);
            this.panelLogSign.Name = "panelLogSign";
            this.panelLogSign.Size = new System.Drawing.Size(776, 426);
            this.panelLogSign.TabIndex = 3;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(416, 335);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(110, 41);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.TabStop = false;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(259, 335);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(110, 41);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.TabStop = false;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(235, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password Manager";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassword.Location = new System.Drawing.Point(296, 220);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(194, 31);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChooseOption
            // 
            this.panelChooseOption.BackColor = System.Drawing.Color.GhostWhite;
            this.panelChooseOption.Controls.Add(this.checkBox1);
            this.panelChooseOption.Controls.Add(this.txtChangePassword);
            this.panelChooseOption.Controls.Add(this.btnBack);
            this.panelChooseOption.Controls.Add(this.btnChangePassword);
            this.panelChooseOption.Controls.Add(this.btnSeePasswords);
            this.panelChooseOption.Controls.Add(this.label1);
            this.panelChooseOption.Location = new System.Drawing.Point(12, 12);
            this.panelChooseOption.Name = "panelChooseOption";
            this.panelChooseOption.Size = new System.Drawing.Size(776, 426);
            this.panelChooseOption.TabIndex = 7;
            this.panelChooseOption.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(460, 280);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtChangePassword
            // 
            this.txtChangePassword.Location = new System.Drawing.Point(249, 278);
            this.txtChangePassword.Name = "txtChangePassword";
            this.txtChangePassword.Size = new System.Drawing.Size(205, 22);
            this.txtChangePassword.TabIndex = 9;
            this.txtChangePassword.UseSystemPasswordChar = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(249, 318);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(273, 41);
            this.btnBack.TabIndex = 8;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(249, 215);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(273, 41);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.TabStop = false;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnSeePasswords
            // 
            this.btnSeePasswords.Location = new System.Drawing.Point(249, 157);
            this.btnSeePasswords.Name = "btnSeePasswords";
            this.btnSeePasswords.Size = new System.Drawing.Size(273, 41);
            this.btnSeePasswords.TabIndex = 6;
            this.btnSeePasswords.TabStop = false;
            this.btnSeePasswords.Text = "See your passwords";
            this.btnSeePasswords.UseVisualStyleBackColor = true;
            this.btnSeePasswords.Click += new System.EventHandler(this.btnSeePasswords_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(164, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "What do you want to do?";
            // 
            // LogSignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChooseOption);
            this.Controls.Add(this.panelLogSign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LogSignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In / Sign Up";
            this.panelLogSign.ResumeLayout(false);
            this.panelLogSign.PerformLayout();
            this.panelChooseOption.ResumeLayout(false);
            this.panelChooseOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panelLogSign;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSignUp;
        private Panel panelChooseOption;
        private Label label1;
        private Button btnBack;
        private Button btnChangePassword;
        private Button btnSeePasswords;
        private CheckBox checkBox1;
        private TextBox txtChangePassword;
    }
}


using Password_Manager.Classes;
using Password_Manager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Password_Manager
{
    public partial class LogSignForm : Form
    {
        // CONSTRUCTORS

        public LogSignForm()
        {
            InitializeComponent();
        }



        // VARIABLES

        private User user = new User(0, "", "");
        public MainMenuForm mainMenu = null;



        // METHODS


        // Function for Log In Click
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            if (user.Username.Length == 0 || user.Password.Length == 0)
            {
                MessageBox.Show("Please fill both fields.");
                return;
            }
            user.Id = DBController.Check_Password(user.Username, user.Password);
            if (user.Id > 0)
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                panelLogSign.Visible = false;
                panelChooseOption.Visible = true;
            }
            else
                MessageBox.Show("The user wasn't found or the username or password are incorrect.");

        }


        // Function for Sign Up Click
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please fill both fields.");
                return;
            }
            
            if (!DBController.Search_User(username))
            {
                DBController.Add_User(username, password);
            }
            else
            {
                MessageBox.Show("User already exists.");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }


        // Function to go the the MainMenuForm to see your passwords
        private void btnSeePasswords_Click(object sender, EventArgs e)
        {
            if(mainMenu == null)
            {
                mainMenu = new MainMenuForm(this, new User(user.Id, user.Username, user.Password));
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("You already have a passwords window open.");
            }
            
        }


        // To go back to the log in page
        private void btnBack_Click(object sender, EventArgs e)
        {
            user.Id = 0;
            user.Username = "";
            user.Password = "";
            txtChangePassword.Text = "";
            if (mainMenu != null)
            {
                mainMenu.Close();
                mainMenu = null;
            }
            panelChooseOption.Visible = false;
            panelLogSign.Visible = true;
            
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string password = txtChangePassword.Text;
            if (password.Length == 0)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            user.Update(user, password);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                txtChangePassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtChangePassword.UseSystemPasswordChar = false;
            }
        }
    }
}

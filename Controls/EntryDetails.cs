using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager.Controls
{
    public partial class EntryDetails : UserControl
    {

        // CONSTRUCTOR


        public EntryDetails()
        {
            InitializeComponent();
        }



        // VARIABLES


        private int _id;
        private string _username;
        private string _website;
        private string _password;



        // GETTERS & SETTERS


        public int Id 
        { 
            get { return _id; }
            set
            {
                _id = value;
                txtId.Text = value.ToString();
            }
        }


        public string Username 
        { 
            get { return _username; }
            set 
            { 
                _username = value;
                txtUsername.Text = value;
            }
        }
  

        public string Website
        {
            get { return _website; }
            set
            {
                _website = value;
                txtWebsite.Text = value;
            }
        }


        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                txtPassword.Text = value;
            }
        }



        // METHODS

        // For showing / hiding the password
        private void button1_Click(object sender, EventArgs e)
        {
            if(panelShowHide.Visible)
            {
                btnShowHide.Text = "Hide";
                panelShowHide.Visible = false;
            }
            else
            {
                btnShowHide.Text = "Show";
                panelShowHide.Visible = true;
            }

        }
    }
}

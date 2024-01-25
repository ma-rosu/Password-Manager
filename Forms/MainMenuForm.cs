using Password_Manager.Classes;
using Password_Manager.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager.Forms
{
    public partial class MainMenuForm : Form
    {

        // CONSTRUCTOR


        public MainMenuForm(LogSignForm logForm, User user)
        {
            User = user;
            Log = logForm;
            InitializeComponent();
            Refresh_Passwords();
        }



        // VARIABLES

        private List<EntryDetails> entries;
        private LogSignForm logForm;


        // GETTERS & SETTERS

        private LogSignForm Log { get; set; }
        public User User { get; set; }
        public string TxtUsername { get { return txtUsername.Text; } set { txtUsername.Text = value; } }
        public string TxtWebsite { get { return txtWebsite.Text; } set { txtWebsite.Text = value; } }
        public string TxtPassword { get { return txtPassword.Text; } set { txtPassword.Text = value; } }
        public string TxtID { get { return txtID.Text; } set { txtID.Text = value; } }

        

        // METHODS


        // To refresh the entries shown on the right of the form
        public void Refresh_Passwords()
        {
            entries = new List<EntryDetails>();
            ICollection<int> keys = User.Entries.Keys;
            flowPanelEntries.Controls.Clear();
            foreach (int key in keys)
            {
                EntryDetails entry_details = new EntryDetails();
                entry_details.Id = User.Entries[key].Id;
                entry_details.Username = User.Entries[key].Username;
                entry_details.Website = User.Entries[key].Website;
                entry_details.Password = User.Entries[key].Password;
                entries.Add(entry_details);
                flowPanelEntries.Controls.Add(entry_details);
            }
        }

        
        // To hide or show generated password
        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (panelShow.Visible)
            {
                panelShow.Visible = false;
                btnShow.Text = "Hide Password";
            }
            else
            {
                panelShow.Visible = true;
                btnShow.Text = "Show Password";
            }
        }
            
        
        // To generate a password
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!checkAlpha.Checked && !checkNum.Checked && !checkSpec.Checked)
                MessageBox.Show("Please check at least one of the options for the password before generating one.");
            else
            {
                PasswordGenerator generator = new PasswordGenerator();
                string generated_password = generator.Generate_Password(checkAlpha.Checked, checkNum.Checked, checkSpec.Checked, int.Parse(numericInsert.Value.ToString()));
                txtGenerated.Text = generated_password;
                txtGenerated.UseSystemPasswordChar = true;
            }
        }

        
        // To copy the generated password
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtGenerated.Text);
        }

        
        // Checks if the check box for the password view was changed
        private void checkView_CheckedChanged(object sender, EventArgs e)
        {
            if(checkView.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        
        // Button to add an entry
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = "0";
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string website = txtWebsite.Text;
            if (username.Length > 0 && password.Length > 0)
            {
                
                if (website.Length > 0)
                {
                    DBController.Add_Entry(User, username, website, password, User.Id);
                }
                else
                {
                    DBController.Add_Entry(User, username, "-", password, User.Id);

                }
                Refresh_Passwords();
            }
            else
            {
                MessageBox.Show("Username and Password input boxes can't be left with the value of null.");
            }
        }

        
        // Button to delete an entry
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SelectIdFormEditDelete select_id_form_edit = new SelectIdFormEditDelete(this, "delete");
            select_id_form_edit.Show();
            Refresh_Passwords();
        }

        
        // Button to edit an entry
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtID.Text) == 0)
            {
                SelectIdFormEditDelete select_id_form_edit = new SelectIdFormEditDelete(this, "edit");
                select_id_form_edit.Show();
            }
            else
            {
                User.Entries[int.Parse(txtID.Text)].Update_Username(TxtUsername);
                User.Entries[int.Parse(txtID.Text)].Update_Website(TxtWebsite);
                User.Entries[int.Parse(txtID.Text)].Update_Password(TxtPassword);
                txtID.Text = "0";
                Refresh_Passwords();
            }
        }

        
    }
}

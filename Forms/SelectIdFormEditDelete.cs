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
    public partial class SelectIdFormEditDelete : Form
    {

        // CONSTRUCTOR

        public SelectIdFormEditDelete(MainMenuForm mmf, string mode)
        {
            InitializeComponent();
            this.mmf = mmf;
            this.mode = mode;
        }



        // VARIABLES

        private MainMenuForm mmf;
        private string mode;

        

        // METHODS


        // For checking the id entered
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSelect.Text.Length == 0)
            {
                MessageBox.Show("Please eneter a valid ID from your list.");
                return;
            }
            if(!txtSelect.Text.All(c => "1234567890".Contains(c)) || !mmf.User.Entries.Keys.Contains(int.Parse(txtSelect.Text)))
            {
                MessageBox.Show("Please eneter a valid ID from your list.");
                return;
            }
            
            if(mode.Equals("edit"))
            {
                mmf.TxtID = txtSelect.Text;
                mmf.TxtUsername = mmf.User.Entries[int.Parse(txtSelect.Text)].Username;
                mmf.TxtWebsite = mmf.User.Entries[int.Parse(txtSelect.Text)].Website;
                mmf.TxtPassword = mmf.User.Entries[int.Parse(txtSelect.Text)].Password;
                this.Close();
            }
            else if(mode.Equals("delete"))
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {txtSelect.Text} entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    mmf.User.Entries[int.Parse(txtSelect.Text)].Delete(mmf.User);
                    mmf.Refresh_Passwords();
                    this.Close();
                }                
                
            }

        }
    }
}

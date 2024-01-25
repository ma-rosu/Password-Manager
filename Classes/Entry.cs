using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.Classes
{
    public class Entry
    {

        // CONSTRUCTOR

        public Entry(int id, string username, string website, string password, int user_id)
        {
            Id = id;
            Username = username;
            Website = website;
            Password = password;
            User_Id = user_id;
        }



        // GETTERS & SETTERS

        public int Id {  get; set; }

        public string Username { get; set; }

        public string Website { get; set; }

        public string Password { get; set; }

        public int User_Id {  get; set; }
        
        

        // METHODS


        // To update username

        public void Update_Username(string new_username)
        {
            DBController.Update_Username_In_Database(this, new_username);
        }


        // To update website

        public void Update_Website(string new_website)
        {
            DBController.Update_Website_In_Database(this, new_website);
        }


        // To update password

        public void Update_Password(string new_password) 
        {
            DBController.Update_Password_In_Database(this, new_password);
        }


        // To delete entry

        public void Delete(User user)
        {
            DBController.Delete_Entry(user, this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager.Classes
{
    public class User
    {
        // CONSTRUCTOR

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
            Entries = DBController.Get_Passwords(id);
        }



        // GETTERS AND SETTERS


        // For the user's id
        public int Id { get; set; }


        // For the user's username
        public string Username { get; set; }


        // For the user's Password
        public string Password { get; set; }


        // For the user's entries
        public Dictionary<int, Entry> Entries { get; set; }



        // METHODS

        // For updating password
        public void Update(User user, string password)
        {
            DBController.Update_User_Password(user, password);
        }
    }
}

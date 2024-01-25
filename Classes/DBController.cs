using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Password_Manager.Classes
{
    internal class DBController
    {
        // METHODS


        // For retrieving the connection string
        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }


        // For searching a specific user in the database, returns true if the user was found
        public static bool Search_User(string username)
        {
            bool result = false;

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand("select username, password from users where username = @username", con))
                    {
                        cmd.Parameters.AddWithValue("@username", username.ToLower());

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            result = reader.Read();

                        }

                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is a problem with the connection to the database.");
                result = false;
            }

            return result;
        }


        // For checking the password for a user in the database, returns the user_id if the password is correct
        public static int Check_Password(string username, string password)
        {
            bool result = false;
            int id = 0;

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand("select password from users where username = @username", con))
                    {
                        cmd.Parameters.AddWithValue("@username", username.ToLower());

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                result = PasswordCrypting.Decrypt(reader["password"].ToString()).Equals(password);
                            }
                        }

                    }

                    if(result)
                    {
                        using(SQLiteCommand cmd = new SQLiteCommand("select id from users where username = @username", con))
                        {
                            cmd.Parameters.AddWithValue("@username", username.ToLower());

                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    id = int.Parse(reader["id"].ToString());
                                }
                            }
                        }
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is a problem with the connection to the database.");
                id = 0;
            }

            return id;
        }


        // For adding a user in the data base, returns true if the user was added
        public static void Add_User(string username, string password)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand("insert into users (username, password) values (@username, @password)", con))
                    {
                        cmd.Parameters.AddWithValue("@username", username.ToLower());
                        cmd.Parameters.AddWithValue("@password", PasswordCrypting.Encrypt(password));

                        cmd.ExecuteNonQuery();
                    }

                    con.Close();
                }
                MessageBox.Show("User signed up successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is a problem with the connection to the database.");
            }
        }


        // Get max ID from entries
        private static int Get_Max_ID()
        {
            int result = 0;
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand("select max(id) as max_id from entries", con))
                    {

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                result = int.Parse(reader["max_id"].ToString());

                            }

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                result = 0;
                MessageBox.Show("There is a problem with the connection to the database.");
            }
            return result;
        }


        // For getting the passwords based on the user ID
        public static Dictionary<int,Entry> Get_Passwords(int user_id)
        {
            Dictionary<int, Entry> entries = new Dictionary<int, Entry>();

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand("select * from entries where user_id = @user_id", con))
                    {

                        cmd.Parameters.AddWithValue("@user_id", user_id);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                Entry entry = new Entry(int.Parse(reader["id"].ToString()), reader["username"].ToString(),
                                    reader["website"].ToString(), PasswordCrypting.Decrypt(reader["password"].ToString()), 
                                    int.Parse(reader["user_id"].ToString()));
                                entries[entry.Id] = entry;

                            }

                        }

                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is a problem with the connection to the database.");
                entries = new Dictionary<int, Entry>(); 
            }

            return entries;
        }


        // For adding entries in the table
        public static void Add_Entry(User user, string username, string website, string password, int user_id)
        {
            Entry entry = new Entry(Get_Max_ID()+1, username, website, password, user_id);

            try
            {
                using(SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Open();
                    using(SQLiteCommand cmd = new SQLiteCommand("insert into entries (username, website, password, user_id) values (@username, @website, @password, @user_id)", con))
                    {
                        cmd.Parameters.AddWithValue("@username", entry.Username);
                        cmd.Parameters.AddWithValue("@website", entry.Website);
                        cmd.Parameters.AddWithValue("@password", PasswordCrypting.Encrypt(entry.Password));
                        cmd.Parameters.AddWithValue("@user_id", entry.User_Id);

                        cmd.ExecuteNonQuery();

                        user.Entries[entry.Id] = entry;
                    }
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is a problem with the connection to the database.");
            }
        }


        // For updating username of an entry
        public static void Update_Username_In_Database(Entry entry, string new_website)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("update entries set username = @new_username where id = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@new_username", new_website);
                        cmd.Parameters.AddWithValue("@id", entry.Id);
                        cmd.ExecuteNonQuery();
                        entry.Username = new_website;
                    }
                    con.Close();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("There is a problem with the connection to the database.");
            }
        }


        // For updating website of an entry
        public static void Update_Website_In_Database(Entry entry, string new_website)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("update entries set website = @new_website where id = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@new_website", new_website);
                        cmd.Parameters.AddWithValue("@id", entry.Id);
                        cmd.ExecuteNonQuery();
                        entry.Website = new_website;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is a problem with the connection to the database.");
            }
        }


        // For updating password of an entry
        public static void Update_Password_In_Database(Entry entry, string new_password)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("update entries set password = @new_password where id = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@new_password", PasswordCrypting.Encrypt(new_password));
                        cmd.Parameters.AddWithValue("@id", entry.Id);
                        cmd.ExecuteNonQuery();
                        entry.Password = new_password;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is a problem with the connection to the database.");
            }
        }


        // For deleting a entries
        public static void Delete_Entry(User user, Entry entry)
        {
            bool result = false;
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("delete from entries where id = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", entry.Id);
                        cmd.ExecuteNonQuery();
                        result = true;
                        user.Entries.Remove(entry.Id);
                    }
                    con.Close();
                    MessageBox.Show("The entry has been deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show("There is a problem with the connection to the database.");
            }
        }


        // For updating the user password
        public static void Update_User_Password(User user, string new_password)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(LoadConnectionString()))
                {
                    con.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("update users set password = @new_password where id = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@new_password", PasswordCrypting.Encrypt(new_password));
                        cmd.Parameters.AddWithValue("@id", user.Id);
                        cmd.ExecuteNonQuery();
                        user.Password = new_password;
                    }
                    con.Close();
                }
                user.Password = new_password;
                MessageBox.Show("The password has been updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is a problem with the connection to the database.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Class_Gasslivery
{
    public class User
    {
        private string id;
        private string username;
        private string password;
        private string role;

        public User()
        {
            this.Id = "";
            this.Username = "";
            this.Password = "";
            this.Role = "";
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public static User CekLogin(string username, string password)
        {
            User userLogin = new User();
            string perintah = $"SELECT * FROM users WHERE username = '{username}' AND password = '{password}'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read())
            {
                userLogin.Id = hasil.GetValue(0).ToString();
                userLogin.Username = hasil.GetValue(1).ToString();
                userLogin.Password = hasil.GetValue(2).ToString();
                userLogin.Role = hasil.GetValue(3).ToString();
                return userLogin;
            }
            else
            {
                return null;
            }
        }
    }
}

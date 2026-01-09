using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Admin
    {
        private string id;
        private string username;
        private string password;

        public Admin()
        {
            this.Id = "";
            this.Username = "";
            this.Password = "";
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public static Admin CekLogin(string username, string password)
        {
            Admin userLogin = new Admin();
            string perintah = $"SELECT * FROM admins WHERE username = '{username}' AND password = '{password}'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read())
            {
                userLogin.Id = hasil.GetValue(0).ToString();
                userLogin.Username = hasil.GetValue(1).ToString();
                userLogin.Password = hasil.GetValue(2).ToString();
                return userLogin;
            }
            else
            {
                return null;
            }
        }
        public override string ToString()
        {
            return Username;
        }
    }
}

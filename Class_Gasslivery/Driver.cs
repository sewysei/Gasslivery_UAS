using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Driver
    {
        private string id;
        private string full_name;
        private string password;
        private DateTime date;
        private string gender; // ENUM('male', 'female')
        private string telp;
        private double avg_rating;
        private double balance;
        private string status; // ENUM('active', 'inactive')

        public Driver()
        {
            this.Id = "";
            this.Full_name = "";
            this.Password = "";
            this.Date = DateTime.Now;
            this.Gender = "";
            this.Telp = "";
            this.Avg_rating = 0;
            this.Balance = 0;
            this.Status = "";
        }

        public string Id { get => id; set => id = value; }
        public string Full_name { get => full_name; set => full_name = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Telp { get => telp; set => telp = value; }
        public double Avg_rating { get => avg_rating; set => avg_rating = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Status { get => status; set => status = value; }

        public static Driver CekLogin(string username, string password)
        {
            Driver userLogin = new Driver();
            string perintah = $"SELECT * FROM drivers WHERE full_name = '{username}' AND password = '{password}'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read())
            {
                userLogin.Id = hasil.GetValue(0).ToString();
                userLogin.Full_name = hasil.GetValue(1).ToString();
                userLogin.Password = hasil.GetValue(2).ToString();
                userLogin.Date = DateTime.Parse(hasil.GetValue(3).ToString()).Date;
                userLogin.Gender = hasil.GetValue(4).ToString();
                userLogin.Telp = hasil.GetValue(5).ToString();
                userLogin.Avg_rating = double.Parse(hasil.GetValue(6).ToString());
                userLogin.Balance = double.Parse(hasil.GetValue(7).ToString());
                userLogin.Status = hasil.GetValue(8).ToString();
                return userLogin;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return Full_name;
        }
    }
}

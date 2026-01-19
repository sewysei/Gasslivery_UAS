using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Consumer
    {
        private string id;
        private string username;
        private string password;
        private DateTime date;
        private string gender; // ENUM('male', 'female')
        private string telp;
        private int balance;
        private int point;

        public Consumer()
        {
            this.Id = "";
            this.Username = "";
            this.Password = "";
            this.Date = DateTime.Now;
            this.Gender = "";
            this.Telp = "";
            this.Balance = 0;
            this.Point = 0;
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Telp { get => telp; set => telp = value; }
        public int Balance { get => balance; set => balance = value; }
        public int Point { get => point; set => point = value; }

        public static Consumer CekLogin(string username, string password)
        {
            string perintah = $"SELECT * FROM consumers WHERE username = '{username}'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            return hasil.Read() ? BacaDataDariReader(hasil) : null;
        }

        public static Consumer CekLoginById(string userId)
        {
            string perintah = $"SELECT * FROM consumers WHERE id = '{userId}'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            return hasil.Read() ? BacaDataDariReader(hasil) : null;
        }

        private static Consumer BacaDataDariReader(MySqlDataReader hasil)
        {
            return new Consumer
            {
                Id = hasil.GetValue(0).ToString(),
                Username = hasil.GetValue(1).ToString(),
                Password = hasil.GetValue(2).ToString(),
                Date = DateTime.Parse(hasil.GetValue(3).ToString()).Date,
                Gender = hasil.GetValue(4).ToString(),
                Telp = hasil.GetValue(5).ToString(),
                Balance = int.Parse(hasil.GetValue(6).ToString()),
                Point = int.Parse(hasil.GetValue(7).ToString())
            };
        }

        public static void UpdateBalance(Consumer consumer)
        {
            string perintah = $"UPDATE consumers SET balance = '{consumer.Balance}' ";
            Koneksi.JalankanPerintahDML(perintah);
        }

        public override string ToString()
        {
            return Username;
        }
    }
}

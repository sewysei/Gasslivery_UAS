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

        public static List<Driver> BacaData(string kolom = "", string nilai = "")
        {
            List<Driver> listHasil = new List<Driver>();
            string perintah;
            if (kolom == "")
            {
                perintah = $"SELECT * FROM drivers";
            }
            else
            {
                perintah = $"SELECT * FROM drivers "+
                    $"WHERE {kolom} = '{nilai}'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                Driver tampung = new Driver();
                tampung.Id = hasil.GetValue(0).ToString();
                tampung.Full_name = hasil.GetValue(1).ToString();
                tampung.Password = hasil.GetValue(2).ToString();
                tampung.Date = DateTime.Parse(hasil.GetValue(3).ToString());
                tampung.Gender = hasil.GetValue(4).ToString();
                tampung.Telp = hasil.GetValue(5).ToString();
                tampung.Avg_rating = double.Parse(hasil.GetValue(6).ToString());
                tampung.Balance = double.Parse(hasil.GetValue(7).ToString());
                tampung.Status = hasil.GetValue(8).ToString();
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public override string ToString()
        {
            return Full_name;
        }

        public static void UpdateRating(string driverId, int newRating)
        {
            // Hitung rata-rata rating baru berdasarkan semua trip driver
            string perintahHitung = $@"SELECT AVG(rating) FROM trips 
                WHERE driver_id = {driverId} AND rating > 0";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintahHitung);
            
            double avgRating = 0;
            if (hasil.Read() && !hasil.IsDBNull(0))
            {
                avgRating = double.Parse(hasil.GetValue(0).ToString());
            }

            string perintah = $@"UPDATE drivers SET avg_rating = {avgRating} 
                WHERE id = {driverId}";
            Koneksi.JalankanPerintahDML(perintah);
        }
        public static void UpdateStatus(string status, string id)
        {
            string perintah = $"UPDATE drivers SET status = '{status}' " +
                $"WHERE id = {id}";

            Koneksi.JalankanPerintahDML(perintah);

        }
    }
}

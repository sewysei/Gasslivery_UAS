using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Class_Gasslivery
{
    public class Tenant
    {
        private string id;
        private string username;
        private string password;
        private string name;
        private string address;
        private string longitude;
        private string latitude;
        private double avg_rating;
        private int total_rating;

        public Tenant()
        {
            this.Id = "";
            this.Username = "";
            this.Password = "";
            this.Name = "";
            this.Address = "";
            this.Longitude = "";
            this.Latitude = "";
            this.Avg_rating = 0;
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Longitude { get => longitude; set => longitude = value; }
        public string Latitude { get => latitude; set => latitude = value; }
        public double Avg_rating { get => avg_rating; set => avg_rating = value; }
        public int Total_rating { get => total_rating; set => total_rating = value; }

        public static Tenant CekLogin(string username, string password)
        {
            Tenant userLogin = new Tenant();
            string perintah = $"SELECT * FROM tenants WHERE username = '{username}' AND password = '{password}'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read())
            {
                userLogin.Id = hasil.GetValue(0).ToString();
                userLogin.Username = hasil.GetValue(1).ToString();
                userLogin.Password = hasil.GetValue(2).ToString();
                userLogin.Name = hasil.GetValue(3).ToString();
                userLogin.Address = hasil.GetValue(4).ToString();
                userLogin.Longitude = hasil.GetValue(5).ToString();
                userLogin.Latitude = hasil.GetValue(6).ToString();
                userLogin.Avg_rating = double.Parse(hasil.GetValue(7).ToString());
                userLogin.Total_rating = int.Parse(hasil.GetValue(8).ToString());
                return userLogin;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public static void UpdateRating(string tenantId, int newRating)
        {
            string perintahAmbil = $@"SELECT avg_rating, total_rating FROM tenants 
                WHERE id = {tenantId}";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintahAmbil);
            
            double avgRating = 0;
            int totalRating = 0;
            
            if (hasil.Read())
            {
                if (!hasil.IsDBNull(0))
                {
                    avgRating = double.Parse(hasil.GetValue(0).ToString());
                }
                if (!hasil.IsDBNull(1))
                {
                    totalRating = int.Parse(hasil.GetValue(1).ToString());
                }
            }

            double avgRatingBaru = (avgRating * totalRating + newRating) / (totalRating + 1);
            int totalRatingBaru = totalRating + 1;

            string perintah = $@"UPDATE tenants SET avg_rating = {avgRatingBaru}, total_rating = {totalRatingBaru} 
                WHERE id = {tenantId}";
            Koneksi.JalankanPerintahDML(perintah);
        }

        public static List<Tenant> BacaData()
        {
            List<Tenant> listHasil = new List<Tenant>();
            string perintah = "SELECT * FROM tenants";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                Tenant tampung = new Tenant();
                tampung.Id = hasil.GetValue(0).ToString();
                tampung.Username = hasil.GetValue(1).ToString();
                tampung.Password = hasil.GetValue(2).ToString();
                tampung.Name = hasil.GetValue(3).ToString();
                tampung.Address = hasil.GetValue(4).ToString();
                tampung.Longitude = hasil.GetValue(5).ToString();
                tampung.Latitude = hasil.GetValue(6).ToString();
                tampung.Avg_rating = double.Parse(hasil.GetValue(7).ToString());
                tampung.Total_rating = int.Parse(hasil.GetValue(8).ToString());
                listHasil.Add(tampung);
            }
            return listHasil;
        }
    }
}

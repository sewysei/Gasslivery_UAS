using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Vehicle
    {
        private string id;
        private Driver driver;
        private string name;
        private string plate;
        private DateTime buy_date;

        public Vehicle()
        {
            this.Id = "";
            this.Driver = new Driver();
            this.Name = "";
            this.Plate = "";
            this.Buy_date = DateTime.Now;
        }

        public string Id { get => id; set => id = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public string Name { get => name; set => name = value; }
        public string Plate { get => plate; set => plate = value; }
        public DateTime Buy_date { get => buy_date; set => buy_date = value; }

        public static List<Vehicle> BacaData(string nilai = "")
        {
            List<Vehicle> listHasil = new List<Vehicle>();
            string perintah;
            if (nilai == "")
            {
                perintah = $"SELECT v.*, d.full_name " +
                    $"FROM vehicles v INNER JOIN drivers d ON d.id = v.driver_id";
            }
            else
            {
                perintah = $"SELECT v.*, d.full_name " +
                    $"FROM vehicles v INNER JOIN drivers d ON d.id = v.driver_id " +
                    $"WHERE plate = '{nilai}'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                Vehicle tampung = new Vehicle();
                tampung.Id = hasil.GetValue(0).ToString();
                tampung.Name = hasil.GetString(1).ToString();
                tampung.Plate = hasil.GetString(2);
                tampung.Buy_date = hasil.GetDateTime(3).Date;
                Driver driver = new Driver();
                driver.Id = hasil.GetValue(4).ToString();
                driver.Full_name = hasil.GetString(5);
                tampung.Driver = driver;
                listHasil.Add(tampung);
            }
            return listHasil;
        }
    }
}

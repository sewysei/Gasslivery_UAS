using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static List<Vehicle> BacaData(string nilai = "", string role = "", string id = "")
        {
            List<Vehicle> listHasil = new List<Vehicle>();
            string perintah = "";
            if (nilai == "" && role == "")
            {
                perintah = $"SELECT v.*, d.full_name " +
                    $"FROM vehicles v INNER JOIN drivers d ON d.id = v.driver_id";
            }
            else if(nilai != "")
            {
                perintah = $"SELECT v.*, d.full_name " +
                    $"FROM vehicles v INNER JOIN drivers d ON d.id = v.driver_id " +
                    $"WHERE plate LIKE '%{nilai}%'";
            }
            else if(role == "driver")
            {
                perintah = $"SELECT v.*, d.full_name " +
                    $"FROM vehicles v INNER JOIN drivers d ON d.id = v.driver_id " +
                    $"WHERE d.id = {id}";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                Vehicle tampung = new Vehicle();
                tampung.Id = hasil.GetValue(0).ToString();
                tampung.Name = hasil.GetValue(1).ToString();
                tampung.Plate = hasil.GetValue(2).ToString();
                tampung.Buy_date = DateTime.Parse(hasil.GetValue(3).ToString());
                Driver driver = new Driver();
                driver.Id = hasil.GetValue(4).ToString();
                driver.Full_name = hasil.GetValue(5).ToString();
                tampung.Driver = driver;
                listHasil.Add(tampung);
            }
            return listHasil;
        }
        public static void Ubah(Vehicle vehicle)
        {
            string perintah = $"UPDATE vehicles SET " +
                $"`name` = '{vehicle.Name}', `plate` = '{vehicle.Plate}', " +
                $"`buy_date` = '{vehicle.Buy_date.ToString("yyyy-MM-dd")}' WHERE(`driver_id` = '{vehicle.Driver.Id}');";

            Koneksi.JalankanPerintahDML(perintah);
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Withdraw
    {
        private string id;
        private int amount;
        private DateTime date;
        private Driver driver;

        public Withdraw()
        {
            this.Id = "";
            this.Amount = 0;    
            this.Date = DateTime.Now;
            this.Driver = new Driver();
        }

        public string Id { get => id; set => id = value; }
        public int Amount { get => amount; set => amount = value; }
        public DateTime Date { get => date; set => date = value; }
        public Driver Driver { get => driver; set => driver = value; }

        public static List<Withdraw> BacaData(string mulai = "", string akhir = "", string id = "")
        {
            List<Withdraw> listHasil = new List<Withdraw>();
            string perintah = "";

            perintah = $"SELECT w.*, d.id, d.full_name " +
                $"FROM withdraws w INNER JOIN drivers d ON d.id = w.driver_id " +
                $"WHERE w.driver_id = {id} AND w.date BETWEEN '{mulai}' AND '{akhir}'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                Withdraw tampung = new Withdraw();
                Driver driver = new Driver();
                tampung.Id = hasil.GetValue(0).ToString();
                tampung.Amount = int.Parse(hasil.GetValue(1).ToString());
                tampung.Date = DateTime.Parse(hasil.GetValue(2).ToString()).Date;
                driver.Id = hasil.GetValue(3).ToString();
                driver.Full_name = hasil.GetValue(4).ToString();
                tampung.Driver = driver;
                listHasil.Add(tampung);
            }
            return listHasil;
        }
        public static void TarikSaldo(Withdraw withdraw)
        {
            string perintah = $"INSERT INTO withdraw (`amount`, `date`, `driver_id`) " +
                $"VALUES ('{withdraw.Amount}', NOW(), '{withdraw.Driver.Id}');";
            Koneksi.JalankanPerintahDML(perintah);
        }
    }
}

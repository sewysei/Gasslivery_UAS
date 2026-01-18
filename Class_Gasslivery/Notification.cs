using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Notification
    {
        private string id;
        private string message;
        private DateTime date;
        private Driver driver;

        public Notification()
        {
            this.Id = "";
            this.Message = "";
            this.Date = DateTime.Now;
            this.Driver = new Driver();
        }

        public string Id { get => id; set => id = value; }
        public string Message { get => message; set => message = value; }
        public DateTime Date { get => date; set => date = value; }
        public Driver Driver { get => driver; set => driver = value; }

        public static void TambahNotifikasi(Notification notif)
        {
            string perintah = $"INSERT INTO notifications (`message`, `date`, `driver_id`) VALUES ('{notif.Message}', NOW(), '{notif.Driver.Id}');";
            Koneksi.JalankanPerintahDML(perintah);
        }

        public static List<Notification> BacaData(string id = "")
        {
            List<Notification> listHasil = new List<Notification>();
            string perintah = "";

            perintah = $"SELECT n.*, d.id, d.full_name " +
                $"FROM notifications n INNER JOIN drivers d ON d.id = n.driver_id " +
                $"WHERE n.driver_id = {id} " +
                $"ORDER BY n.date DESC ";


            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                Notification tampung = new Notification();
                Driver driver = new Driver();
                tampung.Id = hasil.GetValue(0).ToString();
                tampung.Message = hasil.GetValue(1).ToString();
                tampung.Date = DateTime.Parse(hasil.GetValue(2).ToString()).Date;
                driver.Id = hasil.GetValue(3).ToString();
                driver.Full_name = hasil.GetValue(4).ToString();
                tampung.Driver = driver;
                listHasil.Add(tampung);
            }
            return listHasil;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Cancel
    {
        private string id;
        private Trip trip;
        private string reason;
        private DateTime date;

        public Cancel()
        {
            this.Id = "";
            this.Trip = new Trip();
            this.Reason = "";
            this.Date = DateTime.Now;
        }

        public string Id { get => id; set => id = value; }
        public Trip Trip { get => trip; set => trip = value; }
        public string Reason { get => reason; set => reason = value; }
        public DateTime Date { get => date; set => date = value; }

        public static List<Cancel> BacaData(string mulai, string akhir)
        {
            List<Cancel> listHasil = new List<Cancel>();
            string perintah;

            perintah = $"SELECT c.*, d.full_name " +
                $"FROM cancels c INNER JOIN trips t ON t.id = c.trip_id " +
                $"INNER JOIN drivers d ON d.id = t.driver_id " +
                $"WHERE c.date BETWEEN '{mulai}' AND '{akhir}' ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                Cancel tampung = new Cancel();
                Trip trip = new Trip();
                tampung.Id = hasil.GetValue(0).ToString();
                trip.Id = hasil.GetValue(1).ToString();
                tampung.Reason = hasil.GetValue(2).ToString();
                tampung.Date = DateTime.Parse(hasil.GetValue(3).ToString());
                trip.Driver.Full_name = hasil.GetValue(4).ToString();
                tampung.Trip = trip;
                listHasil.Add(tampung);
            }
            return listHasil;
        }
    }
}

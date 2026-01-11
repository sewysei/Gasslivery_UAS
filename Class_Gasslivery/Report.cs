using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Report
    {
        private string id;
        private Trip trip;
        private Admin admin;
        private string messages;
        private string status; // ENUM('open', 'pending', 'closed')
        private DateTime date;

        public Report()
        {
            this.Id = "";
            this.Trip = new Trip();
            this.Admin = new Admin();
            this.Messages = "";
            this.Status = "";
            this.Date = DateTime.Now;
        }

        public string Id { get => id; set => id = value; }
        public Trip Trip { get => trip; set => trip = value; }
        public Admin Admin { get => admin; set => admin = value; }
        public string Messages { get => messages; set => messages = value; }
        public string Status { get => status; set => status = value; }
        public DateTime Date { get => date; set => date = value; }

        public static List<Report> BacaData(string mulai, string akhir)
        {
            List<Report> listHasil = new List<Report>();
            string perintah;
            perintah = $"SELECT r.*, d.full_name, a.username, c.username, d.avg_rating " +
                $"FROM reports r INNER JOIN trips t ON t.id = r.trip_id " +
                $"INNER JOIN drivers d ON d.id = t.driver_id " +
                $"INNER JOIN admins a ON a.id = r.admin_id " +
                $"INNER JOIN consumers c ON c.id = t.consumer_id " +
                $"WHERE r.date BETWEEN '{mulai}' AND '{akhir}' ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                Report tampung = new Report();
                Trip trip = new Trip();
                Admin admin = new Admin();
                tampung.Id = hasil.GetValue(0).ToString();
                trip.Id = hasil.GetValue(1).ToString();
                admin.Id = hasil.GetValue(2).ToString();
                tampung.Messages = hasil.GetValue(3).ToString();
                tampung.Status = hasil.GetValue(4).ToString();
                tampung.Date = DateTime.Parse(hasil.GetValue(5).ToString()).Date;
                trip.Driver.Full_name = hasil.GetValue(6).ToString();
                admin.Username = hasil.GetValue(7).ToString();
                trip.Consumer.Username = hasil.GetValue(8).ToString();
                trip.Driver.Avg_rating = double.Parse(hasil.GetValue(9).ToString());
                tampung.Trip = trip;
                tampung.Admin = admin;
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void UbahStatus(Report objUbah)
        {
            string perintah = $"UPDATE reports SET admin_id = {objUbah.Admin.Id} , status = '{objUbah.Status}' WHERE id = {objUbah.Id};";
            string perintah2 = $"UPDATE drivers SET avg_rating = {objUbah.Trip.Driver.Avg_rating} WHERE full_name = '{objUbah.Trip.Driver.Full_name}'";

            Koneksi.JalankanPerintahDML(perintah);
            Koneksi.JalankanPerintahDML(perintah2);
        }

        public static void TambahReport(Report report)
        {
            string messages = report.Messages.Replace("'", "''");
            string perintah = $@"INSERT INTO reports (trip_id, admin_id, messages, status, date) 
                VALUES ({report.Trip.Id}, NULL, '{messages}', 'open', NOW())";
            Koneksi.JalankanPerintahDML(perintah);
        }
    }
}

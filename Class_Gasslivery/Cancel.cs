using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public static void CetakLaporan(string mulai, string akhir)
        {
            List<Cancel> listCetak = BacaData(mulai, akhir);
            string namaFile = DateTime.Now.ToString("yyyy-MM-dd") + "_laporan_cancel";
            StreamWriter fileCetak = new StreamWriter(namaFile);
            //HEADER LAPORAN:
            fileCetak.WriteLine($"Laporan Cancel periode {mulai} sampai {akhir}");
            fileCetak.WriteLine("dicetak pada tanggal " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
            fileCetak.WriteLine("");
            //ISI LAPORAN:
            for (int i = 0; i < listCetak.Count; i++)
            {
                fileCetak.WriteLine(listCetak[i].Id + "     " + listCetak[i].Trip.Driver.Full_name + "     " + listCetak[i].Date.ToString("yyyy-MM-dd"));
            }
            //FOOTER LAPORAN:
            fileCetak.WriteLine("");
            fileCetak.WriteLine("end of document");
            fileCetak.Close();

            Font tipeFont = new Font("Courier New", 8);
            Printing p = new Printing(tipeFont, namaFile, 30, 30, 30, 30);
            p.KirimKePrinter();
        }

        public static void TambahCancel(Cancel cancel)
        {
            string reason = cancel.Reason.Replace("'", "''");
            string perintah = $@"INSERT INTO cancels (trip_id, reason, date) 
                VALUES ({cancel.Trip.Id}, '{reason}', NOW())";
            Koneksi.JalankanPerintahDML(perintah);
            
            // Update status trip menjadi canceled
            Trip trip = cancel.Trip;
            trip.Status = "canceled";
            Trip.UpdateStatus(trip);
        }
    }
}

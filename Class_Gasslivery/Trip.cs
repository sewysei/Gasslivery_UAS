using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Gasslivery
{
    public class Trip
    {
        private string id;
        private Consumer consumer;
        private Driver driver;
        private Voucher voucher;
        private string longitude_pickup;
        private string latitude_pickup;
        private string pickup_point;
        private string longitude_dest;
        private string latitude_dest;
        private string destination_point;
        private double distance;
        private string pickup_time;
        private string fee;
        private int rating;
        private string status; // ENUM('pending', 'ongoing', 'completed', 'canceled')
        private DateTime date;
        private int additional_fee;
        private int discount_value;
        private int total_fee;

        public Trip()
        {
            this.Id = "";
            this.Consumer = new Consumer();
            this.Driver = new Driver();
            this.Voucher = new Voucher();
            this.Longitude_pickup = "";
            this.Latitude_pickup = "";
            this.Pickup_point = "";
            this.Longitude_dest = "";
            this.Latitude_dest = "";
            this.Destination_point = "";
            this.Distance = 0;
            this.Pickup_time = "";
            this.Fee = "";
            this.Rating = 0;
            this.Status = "";
            this.Date = DateTime.Now;
            this.Additional_fee = 0;
            this.Discount_value = 0;
            this.Total_fee = 0;
        }

        public Trip(Consumer consumer, Driver driver, Voucher voucher, string pickup, string destination, double distance, string fee, string status, DateTime date, int total)
        {
            this.Consumer = consumer;
            this.Driver = driver;
            this.Voucher = voucher;
            this.Pickup_point = pickup;
            this.Destination_point = destination;
            this.Distance = distance;
            this.Fee = fee;
            this.Status = status;
            this.Date = date;
            this.Total_fee = total;
        }

        public string Id { get => id; set => id = value; }
        public Consumer Consumer { get => consumer; set => consumer = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public Voucher Voucher { get => voucher; set => voucher = value; }
        public string Longitude_pickup { get => longitude_pickup; set => longitude_pickup = value; }
        public string Latitude_pickup { get => latitude_pickup; set => latitude_pickup = value; }
        public string Pickup_point { get => pickup_point; set => pickup_point = value; }
        public string Longitude_dest { get => longitude_dest; set => longitude_dest = value; }
        public string Latitude_dest { get => latitude_dest; set => latitude_dest = value; }
        public string Destination_point { get => destination_point; set => destination_point = value; }
        public double Distance { get => distance; set => distance = value; }
        public string Pickup_time { get => pickup_time; set => pickup_time = value; }
        public string Fee { get => fee; set => fee = value; }
        public int Rating { get => rating; set => rating = value; }
        public string Status { get => status; set => status = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Additional_fee { get => additional_fee; set => additional_fee = value; }
        public int Discount_value { get => discount_value; set => discount_value = value; }
        public int Total_fee { get => total_fee; set => total_fee = value; }

        public static List<Trip> BacaData(string mulai, string akhir)
        {
            List<Trip> listHasil = new List<Trip>();
            string perintah;
            perintah = $"SELECT t.*, c.username, d.full_name, v.name " +
            $"FROM trips t INNER JOIN consumers c ON c.id = t.consumer_id " +
            $"INNER JOIN drivers d ON t.driver_id = d.id " +
            $"LEFT JOIN vouchers v ON v.id = t.voucher_id " +
            $"WHERE t.date BETWEEN '{mulai}' AND '{akhir}' " +
            $"ORDER BY t.date ASC";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                Trip tampung = new Trip();
                Consumer consumer = new Consumer();
                Driver driver = new Driver();
                Voucher voucher = new Voucher();
                tampung.Id = hasil.GetValue(0).ToString();
                consumer.Id = hasil.GetValue(1).ToString();
                driver.Id = hasil.GetValue(2).ToString();
                voucher.Id = hasil.GetValue(3).ToString();
                tampung.Longitude_pickup = hasil.GetValue(4).ToString();
                tampung.Latitude_pickup = hasil.GetValue(5).ToString();
                tampung.Pickup_point = hasil.GetValue(6).ToString();
                tampung.Longitude_dest = hasil.GetValue(7).ToString();
                tampung.Latitude_dest = hasil.GetValue(8).ToString();
                tampung.Destination_point = hasil.GetValue(9).ToString();
                tampung.Distance = double.Parse(hasil.GetValue(10).ToString());
                tampung.Pickup_time = hasil.GetValue(11).ToString();
                tampung.Fee = hasil.GetValue(12).ToString();
                tampung.Rating = int.Parse(hasil.GetValue(13).ToString());
                tampung.Status = hasil.GetValue(14).ToString();
                tampung.Date = DateTime.Parse(hasil.GetValue(15).ToString()).Date;
                tampung.Additional_fee = int.Parse(hasil.GetValue(16).ToString());
                tampung.Discount_value = int.Parse(hasil.GetValue(17).ToString());
                tampung.Total_fee = int.Parse(hasil.GetValue(18).ToString());
                consumer.Username = hasil.GetValue(19).ToString();
                driver.Full_name = hasil.GetValue(20).ToString();
                voucher.Name = hasil.GetValue(21).ToString();
                tampung.Consumer = consumer;
                tampung.Driver = driver;
                tampung.Voucher = voucher;
                listHasil.Add(tampung);
            }
            return listHasil;
        }
        public override string ToString()
        {
            return Driver.Full_name;
        }

        public static void CetakLaporan(string mulai, string akhir)
        {
            List<Trip> listCetak = BacaData(mulai, akhir);
            string namaFile = DateTime.Now.ToString("yyyy-MM-dd") + "_laporan_transaksi_Gass-ride";
            StreamWriter fileCetak = new StreamWriter(namaFile);
            //HEADER LAPORAN:
            fileCetak.WriteLine($"Laporan Transaksi Gass-Ride periode {mulai} sampai {akhir}");
            fileCetak.WriteLine("dicetak pada tanggal " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
            fileCetak.WriteLine("");
            //ISI LAPORAN:
            for (int i = 0; i < listCetak.Count; i++)
            {
                fileCetak.WriteLine(listCetak[i].Id + "     " + listCetak[i].Consumer.Username + "     " + listCetak[i].Driver.Full_name + "     " + listCetak[i].Pickup_point + "     " + listCetak[i].Destination_point + "     " + listCetak[i].Total_fee + "     " + listCetak[i].Date.ToString("yyyy-MM-dd"));
            }
            //FOOTER LAPORAN:
            fileCetak.WriteLine("");
            fileCetak.WriteLine("end of document");
            fileCetak.Close();

            Font tipeFont = new Font("Courier New", 8);
            Printing p = new Printing(tipeFont, namaFile, 30, 30, 30, 30);
            p.KirimKePrinter();
        }
    }
}

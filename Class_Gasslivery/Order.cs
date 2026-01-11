using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Gasslivery
{
    public class Order
    {
        private string id;
        private Consumer consumer;
        private Delivery delivery;
        private Tenant tenant;
        private Voucher voucher;
        private DateTime date;
        private string status; // ENUM('pending', 'processing', 'delivered', 'cancelled')
        private int food_rating;
        private int driver_rating;
        private int tip;
        private int discount_value;
        private int total_fee;

        public Order()
        {
            this.Id = "";
            this.Consumer = new Consumer();
            this.Delivery = new Delivery();
            this.Tenant = new Tenant();
            this.Voucher = new Voucher();
            this.Date = DateTime.Now;
            this.Status = "";
            this.Food_rating = 0;
            this.Driver_rating = 0;
            this.Tip = 0;
            this.Discount_value = 0;
            this.Total_fee = 0;
        }

        public string Id { get => id; set => id = value; }

        public Consumer Consumer { get => consumer; set => consumer = value; }
        public Delivery Delivery { get => delivery; set => delivery = value; }
        public Tenant Tenant { get => tenant; set => tenant = value; }
        public Voucher Voucher { get => voucher; set => voucher = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Status { get => status; set => status = value; }
        public int Food_rating { get => food_rating; set => food_rating = value; }
        public int Driver_rating { get => driver_rating; set => driver_rating = value; }
        public int Tip { get => tip; set => tip = value; }
        public int Discount_value { get => discount_value; set => discount_value = value; }
        public int Total_fee { get => total_fee; set => total_fee = value; }

        public static List<Order> BacaData(string kolom = "", string nilai = "", string id = "", string mulai = "", string akhir = "")
        {
            List<Order> listHasil = new List<Order>();
            string perintah = "";
            if(kolom == "")
            {
                perintah = $"SELECT o.*, c.username, dr.full_name, v.name, t.name, d.destination_point, d.fee " +
                    $"FROM orders o INNER JOIN consumers c ON c.id = o.consumer_id " +
                    $"INNER JOIN deliveries d ON d.id = o.delivery_id " +
                    $"INNER JOIN drivers dr ON dr.id = d.driver_id " +
                    $"INNER JOIN tenants t ON t.id = o.tenant_id " +
                    $"LEFT JOIN vouchers v ON v.id = o.voucher_id " +
                    $"WHERE o.date BETWEEN '{mulai}' AND '{akhir}' " +
                    $"ORDER BY o.date ASC";
            }
            else if(kolom == "status")
            {
                perintah = $"SELECT o.*, c.username, dr.full_name, v.name, t.name, d.destination_point, d.fee " +
                   $"FROM orders o INNER JOIN consumers c ON c.id = o.consumer_id " +
                   $"INNER JOIN deliveries d ON d.id = o.delivery_id " +
                   $"INNER JOIN drivers dr ON dr.id = d.driver_id " +
                   $"INNER JOIN tenants t ON t.id = o.tenant_id " +
                   $"LEFT JOIN vouchers v ON v.id = o.voucher_id " +
                   $"WHERE o.status = '{nilai}' AND o.tenant_id = '{id}' " +
                   $"ORDER BY o.date ASC";
            }
            else if (kolom == "date")
            {
                perintah = $"SELECT o.*, c.username, dr.full_name, v.name, t.name, d.destination_point, d.fee " +
                   $"FROM orders o INNER JOIN consumers c ON c.id = o.consumer_id " +
                   $"INNER JOIN deliveries d ON d.id = o.delivery_id " +
                   $"INNER JOIN drivers dr ON dr.id = d.driver_id " +
                   $"INNER JOIN tenants t ON t.id = o.tenant_id " +
                   $"LEFT JOIN vouchers v ON v.id = o.voucher_id " +
                   $"WHERE o.date BETWEEN '{mulai}' AND '{akhir}' AND o.tenant_id = {id} AND o.status = delivered " +
                   $"ORDER BY o.date ASC";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                Order tampung = new Order();
                Delivery delivery = new Delivery();
                Consumer consumer = new Consumer();
                Tenant tenant = new Tenant();
                Voucher voucher = new Voucher();
                tampung.Id = hasil.GetValue(0).ToString();
                delivery.Id = hasil.GetValue(1).ToString();
                tenant.Id = hasil.GetValue(2).ToString();
                voucher.Id = hasil.GetValue(3).ToString();
                tampung.Date = DateTime.Parse(hasil.GetValue(4).ToString()).Date;
                tampung.Status = hasil.GetValue(5).ToString();
                tampung.Food_rating = int.Parse(hasil.GetValue(6).ToString());
                tampung.Driver_rating = int.Parse(hasil.GetValue(7).ToString());
                tampung.Tip = int.Parse(hasil.GetValue(8).ToString());
                tampung.Discount_value = int.Parse(hasil.GetValue(9).ToString());
                tampung.Total_fee = int.Parse(hasil.GetValue(10).ToString());
                consumer.Id = hasil.GetValue(11).ToString();
                consumer.Username = hasil.GetValue(12).ToString();
                delivery.Driver.Full_name = hasil.GetValue(13).ToString();
                voucher.Name = hasil.GetValue(14).ToString();
                tenant.Name = hasil.GetValue(15).ToString();
                delivery.Destination_point = hasil.GetValue(16).ToString();
                delivery.Fee = int.Parse(hasil.GetValue(17).ToString());
                tampung.Consumer = consumer;
                tampung.Delivery = delivery;
                tampung.Tenant = tenant;
                tampung.Voucher = voucher;
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public override string ToString()
        {
            return Id;
        }

        public static void CetakLaporan(string mulai, string akhir)
        {
            List<Order> listCetak = BacaData(mulai, akhir);
            string namaFile = DateTime.Now.ToString("yyyy-MM-dd") + "_laporan_transaksi_Gass-kan";
            StreamWriter fileCetak = new StreamWriter(namaFile);
            //HEADER LAPORAN:
            fileCetak.WriteLine($"Laporan Transaksi Gass-kan periode {mulai} sampai {akhir}");
            fileCetak.WriteLine("dicetak pada tanggal " + DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
            fileCetak.WriteLine("");
            //ISI LAPORAN:
            for (int i = 0; i < listCetak.Count; i++)
            {
                fileCetak.WriteLine(listCetak[i].Id + "     " + listCetak[i].Consumer.Username + "     " + listCetak[i].Tenant.Name + "     " + listCetak[i].Delivery.Driver.Full_name + "     " + listCetak[i].Total_fee + "     " + listCetak[i].Date.ToString("yyyy-MM-dd"));
            }
            //FOOTER LAPORAN:
            fileCetak.WriteLine("");
            fileCetak.WriteLine("end of document");
            fileCetak.Close();

            Font tipeFont = new Font("Courier New", 8);
            Printing p = new Printing(tipeFont, namaFile, 30, 30, 30, 30);
            p.KirimKePrinter();
        }

        public static void GantiStatus(Order order)
        {
            string perintah = $"UPDATE orders SET status = '{order.Status}' ";
            Koneksi.JalankanPerintahDML(perintah);
        }

    }
}

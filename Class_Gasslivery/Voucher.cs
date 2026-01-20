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
    public class Voucher
    {
        private string id;
        private string name;
        private string conditions;
        private string value;

        public Voucher()
        {
            this.Id = "";
            this.Name = "";
            this.Conditions = "";
            this.Value = "";
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Conditions { get => conditions; set => conditions = value; }
        public string Value { get => value; set => this.value = value; }

        public static List<Voucher> BacaData(string kolom = "", string nilai = "")
        {
            List<Voucher> listHasil = new List<Voucher>();
            string perintah;
            perintah = $"SELECT * FROM vouchers ORDER BY CAST(value AS UNSIGNED) ASC;";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                Voucher tampung = new Voucher();
                tampung.Id = hasil.GetValue(0).ToString();
                tampung.Name = hasil.GetValue(1).ToString();
                tampung.Conditions = hasil.GetValue(2).ToString();
                tampung.Value = hasil.GetValue(3).ToString();
                listHasil.Add(tampung);
            }
            return listHasil;
        }
        public override string ToString()
        {
            return Name;
        }
        public static void Tambah(Voucher voucher)
        {
            string perintah = $"INSERT INTO vouchers (`name`, `conditions`, `value`) " +
                $"VALUES ('{voucher.Name}', '{voucher.conditions}', '{voucher.Value}');";
            Koneksi.JalankanPerintahDML(perintah);
        }

        public static void Hapus(Voucher voucher)
        {
            string perintah = $"DELETE FROM vouchers WHERE(`id` = {voucher.Id})";

            Koneksi.JalankanPerintahDML(perintah);
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class TopUp
    {
        private string id;
        private int amount;
        private DateTime date;
        private Consumer consumer;

        public TopUp()
        {
            this.Id = "";
            this.Amount = 0;
            this.Date = DateTime.Now;
            this.Consumer = new Consumer();
        }

        public string Id { get => id; set => id = value; }
        public int Amount { get => amount; set => amount = value; }
        public DateTime Date { get => date; set => date = value; }
        public Consumer Consumer { get => consumer; set => consumer = value; }

        public static List<TopUp> BacaData(string mulai = "", string akhir = "", string id = "")
        {
            List<TopUp> listHasil = new List<TopUp>();
            string perintah = "";

            perintah = $"SELECT t.*, c.id, c.username " +
                $"FROM topups t INNER JOIN consumers c ON c.id = t.consumer_id " +
                $"WHERE t.consumer_id = {id} AND t.date BETWEEN '{mulai}' AND '{akhir}' " +
                $"ORDER BY t.date DESC ";
            

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                TopUp tampung = new TopUp();
                Consumer consumer = new Consumer();
                tampung.Id = hasil.GetValue(0).ToString();
                tampung.Amount = hasil.GetInt32(1);
                tampung.Date = hasil.GetDateTime(2);
                consumer.Id = hasil.GetValue(3).ToString();
                consumer.Username = hasil.GetString(4);
                tampung.Consumer = consumer;
                listHasil.Add(tampung);
            }
            return listHasil;
        }

        public static void TambahSaldo(TopUp topap)
        {
            string perintah = $"INSERT INTO topups (`amount`, `date`, `consumer_id`) " +
                $"VALUES ('{topap.Amount}', NOW(), '{topap.Consumer.Id}');";
            Koneksi.JalankanPerintahDML(perintah);
        }
    }
}

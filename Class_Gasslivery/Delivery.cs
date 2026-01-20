using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Delivery
    {
        private string id;
        private Driver driver;
        private int fee;
        private string longitude_dest;
        private string latitude_dest;
        private string destination_point;
        private DateTime date;

        public Delivery()
        {
            this.Id = "";
            this.Driver = new Driver();
            this.Fee = 0;
            this.Longitude_dest = "";
            this.Latitude_dest = "";
            this.Destination_point = "";
            this.Date = DateTime.Now;
        }

        public string Id { get => id; set => id = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public int Fee { get => fee; set => fee = value; }
        public string Longitude_dest { get => longitude_dest; set => longitude_dest = value; }
        public string Latitude_dest { get => latitude_dest; set => latitude_dest = value; }
        public string Destination_point { get => destination_point; set => destination_point = value; }
        public DateTime Date { get => date; set => date = value; }

        public override string ToString()
        {
            return Destination_point;
        }

        public static int BuatDelivery(Delivery delivery)
        {
            string perintah = "";

            perintah = $"INSERT INTO deliveries " +
                $"(`driver_id`, `fee`, `longitude_dest`, `latitude_dest`, `destination_point`, `date`) " +
                $"VALUES ('1', '{delivery.Fee}', '{delivery.Longitude_dest}', '{delivery.Latitude_dest}', '{delivery.Destination_point}', NOW()); " +
                $"SELECT LAST_INSERT_ID();";

            int idBaru = Koneksi.GetLastInsertId(perintah);

            return idBaru;
        }

        public static void GantiDriver(string id, string idDelivery)
        {
            string perintah = $"UPDATE deliveries SET driver_id = '{id}' WHERE id = '{idDelivery}'";
            Koneksi.JalankanPerintahDML(perintah);
        }
    }
}

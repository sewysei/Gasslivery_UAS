using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

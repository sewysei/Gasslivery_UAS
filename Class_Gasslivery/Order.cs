using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Order
    {
        private string id;
        private Delivery delivery;
        private Tenant tenant;
        private Voucher voucher;
        private DateTime date;
        private string status; // ENUM('pending', 'processing', 'delivered')
        private int food_rating;
        private int driver_rating;
        private int tip;
        private int discount_value;
        private int total_fee;

        public Order()
        {
            this.Id = "";
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
    }
}

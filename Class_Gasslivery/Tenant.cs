using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Tenant
    {
        private string id;
        private string username;
        private string password;
        private string mail;
        private string address;
        private string longitude;
        private string latitude;
        private double avg_rating;

        public Tenant()
        {
            this.Id = "";
            this.Username = "";
            this.Password = "";
            this.Mail = "";
            this.Address = "";
            this.Longitude = "";
            this.Latitude = "";
            this.Avg_rating = 0;
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Address { get => address; set => address = value; }
        public string Longitude { get => longitude; set => longitude = value; }
        public string Latitude { get => latitude; set => latitude = value; }
        public double Avg_rating { get => avg_rating; set => avg_rating = value; }
    }
}

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
    }
}

using System;
using System.Collections.Generic;
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
    }
}

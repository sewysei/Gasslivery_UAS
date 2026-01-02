using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Notification
    {
        private string id;
        private string message;
        private DateTime date;
        private Driver driver;

        public Notification()
        {
            this.Id = "";
            this.Message = "";
            this.Date = DateTime.Now;
            this.Driver = new Driver();
        }

        public string Id { get => id; set => id = value; }
        public string Message { get => message; set => message = value; }
        public DateTime Date { get => date; set => date = value; }
        public Driver Driver { get => driver; set => driver = value; }
    }
}

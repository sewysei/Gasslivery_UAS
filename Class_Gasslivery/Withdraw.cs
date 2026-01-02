using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Withdraw
    {
        private string id;
        private int amount;
        private DateTime date;
        private Driver driver;

        public Withdraw()
        {
            this.Id = "";
            this.Amount = 0;    
            this.Date = DateTime.Now;
            this.Driver = new Driver();
        }

        public string Id { get => id; set => id = value; }
        public int Amount { get => amount; set => amount = value; }
        public DateTime Date { get => date; set => date = value; }
        public Driver Driver { get => driver; set => driver = value; }
    }
}

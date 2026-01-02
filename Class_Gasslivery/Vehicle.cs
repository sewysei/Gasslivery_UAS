using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class Vehicle
    {
        private string id;
        private Driver driver;
        private string name;
        private string plate;
        private DateTime buy_date;

        public Vehicle()
        {
            this.Id = "";
            this.Driver = new Driver();
            this.Name = "";
            this.Plate = "";
            this.Buy_date = DateTime.Now;
        }

        public string Id { get => id; set => id = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public string Name { get => name; set => name = value; }
        public string Plate { get => plate; set => plate = value; }
        public DateTime Buy_date { get => buy_date; set => buy_date = value; }
    }
}

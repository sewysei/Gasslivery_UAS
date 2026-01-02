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
    }
}

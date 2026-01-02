using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Gasslivery
{
    public class OrderDetail
    {
        private Menu menu;
        private Order order;
        private int total_price;
        private int amount;

        public OrderDetail()
        {
            this.Menu = new Menu();
            this.Order = new Order();
            this.Total_price = 0;
            this.Amount = 0;
        }

        public Menu Menu { get => menu; set => menu = value; }
        public Order Order { get => order; set => order = value; }
        public int Total_price { get => total_price; set => total_price = value; }
        public int Amount { get => amount; set => amount = value; }
    }
}

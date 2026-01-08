using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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

        public static List<OrderDetail> BacaData(string id)
        {
            List<OrderDetail> listHasil = new List<OrderDetail>();
            string perintah;

            perintah = $"SELECT od.*, m.name " +
                $"FROM order_details od " +
                $"INNER JOIN orders o ON o.id = od.order_id " +
                $"INNER JOIN menus m ON m.id = od.menu_id " +
                $"WHERE o.id = {id}";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            while (hasil.Read())
            {
                OrderDetail tampung = new OrderDetail();
                Order order = new Order();
                Menu menu = new Menu();
                menu.Id = hasil.GetValue(0).ToString();
                order.Id = hasil.GetValue(1).ToString();
                tampung.Total_price = int.Parse(hasil.GetValue(2).ToString());
                tampung.Amount = int.Parse(hasil.GetValue(3).ToString());
                menu.Name = hasil.GetValue(4).ToString();
                tampung.Order = order;
                tampung.Menu = menu;
                listHasil.Add(tampung);
            }
            return listHasil;
        }
    }
}
